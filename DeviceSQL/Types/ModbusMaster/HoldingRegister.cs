using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Text;

    public partial class UserDefinedTypes
    {
        [Serializable()]
        [SqlUserDefinedType(Format.UserDefined, IsByteOrdered = false, IsFixedLength = false, MaxByteSize = 10)]
        public struct HoldingRegister : INullable, IBinarySerialize
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
                        data = new byte[2];
                    }
                    return data;
                }
                set
                {
                    data = value.Value;
                }
            }

            public ModbusAddress Address
            {
                get;
                set;
            }

            public SqlBoolean ByteSwap
            {
                get;
                set;
            }

            public bool IsNull
            {
                get;
                private set;
            }

            public SqlInt32 Value
            {
                get
                {
                    return new Device.Modbus.Data.HoldingRegister(new Device.Modbus.Data.ModbusAddress(Convert.ToUInt16(Address.RelativeAddress), Address.IsZeroBased.Value), ByteSwap.Value).Value;
                }
                set
                {
                    Data = new Device.Modbus.Data.HoldingRegister(new Device.Modbus.Data.ModbusAddress(Convert.ToUInt16(Address.RelativeAddress), Address.IsZeroBased.Value), ByteSwap.Value) { Value = Convert.ToUInt16(value) }.Data;
                }
            }

            public static HoldingRegister Null
            {
                get
                {
                    return (new HoldingRegister() { IsNull = true });
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
                    return string.Format("Address=[{0}];Byte Swap={1};Value={2};", Address.ToString(), ByteSwap.Value, Value.Value);
                }
            }

            public static HoldingRegister Parse(SqlString stringToParse)
            {
                if (stringToParse.IsNull)
                {
                    return Null;
                }

                var parsedHoldingRegisterData = stringToParse.Value.Split(",".ToCharArray());
                var parsedHoldingRegister = new HoldingRegister() { Address = ModbusAddress.Parse(parsedHoldingRegisterData[0]), ByteSwap = bool.Parse(parsedHoldingRegisterData[1]), Value = UInt16.Parse(parsedHoldingRegisterData[2]) };
                return parsedHoldingRegister;
            }

            #endregion

            #region Serialization Methods

            public void Read(BinaryReader binaryReader)
            {
                IsNull = binaryReader.ReadBoolean();

                if (!IsNull)
                {
                    Address.Read(binaryReader);
                    ByteSwap = binaryReader.ReadBoolean();
                    Data = binaryReader.ReadBytes(2);
                }

            }

            public void Write(BinaryWriter binaryWriter)
            {
                binaryWriter.Write(IsNull);

                if (!IsNull)
                {
                    Address.Write(binaryWriter);
                    binaryWriter.Write(ByteSwap.Value);
                    binaryWriter.Write(Data.Value, 0, 2);
                }
            }

            #endregion

        }
    }