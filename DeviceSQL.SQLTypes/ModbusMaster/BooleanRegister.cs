#region Imported Types

using Microsoft.SqlServer.Server;
using System;
using System.Data.SqlTypes;
using System.IO;

#endregion

namespace DeviceSQL.SQLTypes.MODBUSMaster
{
    [Serializable()]
    [SqlUserDefinedType(Format.UserDefined, IsByteOrdered = false, IsFixedLength = false, MaxByteSize = 8)]
    public struct MODBUSMaster_BooleanRegister : INullable, IBinarySerialize
    {

        #region Fields

        internal byte[] data;

        #endregion

        #region Properties

        public SqlBinary Data
        {
            get
            {
                if (data == null)
                {
                    data = new byte[1];
                }
                return data;
            }
            set
            {
                data = value.Value;
            }
        }

        public MODBUSMaster_MODBUSAddress Address
        {
            get;
            set;
        }

        public bool IsNull
        {
            get;
            private set;
        }

        public SqlBoolean Value
        {
            get
            {
                return new DeviceSQL.Device.MODBUS.Data.BooleanRegister(new DeviceSQL.Device.MODBUS.Data.MODBUSAddress(Convert.ToUInt16(Address.RelativeAddress), Address.IsZeroBased.Value)).Value;
            }
            set
            {
                Data = new DeviceSQL.Device.MODBUS.Data.BooleanRegister(new DeviceSQL.Device.MODBUS.Data.MODBUSAddress(Convert.ToUInt16(Address.RelativeAddress), Address.IsZeroBased.Value)) { Value = value.Value }.Data;
            }
        }

        public static MODBUSMaster_BooleanRegister Null
        {
            get
            {
                return (new MODBUSMaster_BooleanRegister() { IsNull = true });
            }
        }

        #endregion

        #region Helper Methods

        public override string ToString()
        {
            if (this.IsNull)
            {
                return "NULL";
            }
            else
            {
                return string.Format("Address=[{0}];Value={1};", Address.ToString(), Value.Value);
            }
        }

        public static MODBUSMaster_BooleanRegister Parse(SqlString stringToParse)
        {
            if (stringToParse.IsNull)
            {
                return Null;
            }

            var parsedBooleanRegisterData = stringToParse.Value.Split(",".ToCharArray());
            var parsedBooleanRegister = new MODBUSMaster_BooleanRegister() { Address = MODBUSMaster_MODBUSAddress.Parse(parsedBooleanRegisterData[0]), Value = bool.Parse(parsedBooleanRegisterData[1]) };
            return parsedBooleanRegister;
        }

        #endregion

        #region Serialization Methods

        public void Read(BinaryReader binaryReader)
        {
            IsNull = binaryReader.ReadBoolean();

            if (!IsNull)
            {
                Address.Read(binaryReader);
                Data = binaryReader.ReadBytes(1);
            }

        }

        public void Write(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(IsNull);

            if (!IsNull)
            {
                Address.Write(binaryWriter);
                binaryWriter.Write(Data.Value, 0, 1);
            }
        }

        #endregion

    }
}