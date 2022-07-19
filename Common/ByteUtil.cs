using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOLHelper.Common
{
    internal class ByteUtil
    {
        
        /// <summary>
        /// 字节数组裁剪
        /// </summary>
        /// <param name="value"></param>
        /// <param name="cut"></param>
        /// <returns></returns>
        public static byte[] ByteCut(byte[] value, byte cut = 0x00)
        {
            var list = new List<byte>();
            list.AddRange(value);
            for (var i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == cut)
                    list.RemoveAt(i);
            }
            var lastbyte = new byte[list.Count];
            for (var i = 0; i < list.Count; i++)
            {
                lastbyte[i] = list[i];
            }
            return lastbyte;
        }
    }
}
