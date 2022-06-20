using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace BLUEBOX_Polling
{
    class BLUEBOXLibClass_x32:BLUEBOXLibInterface
    {
        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_GetSwRelease(System.Text.StringBuilder SwRel);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_Init(out int Handle);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_End(ref int Handle);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_SetAddress(ref int Handle, byte Address);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_SetChannel(ref int Handle, String Channel, String Settings);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_Open(ref int Handle);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_Close(ref int Handle);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_GetFwRelease(ref int Handle, int Reader, System.Text.StringBuilder FwRel);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_ReadParameters(ref int Handle, byte[] Parameters);

        [StructLayout(LayoutKind.Sequential)]
        public struct BLUEBOX_Tag
        {
            internal int TagType;
            internal IntPtr Id;
            internal int Length;
            internal int Antenna;
            internal int Input;
        };

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_DataRequest(ref int Handle, out IntPtr Tags, out int TagsNo);

        [DllImport("/x86/BLUEBOXLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        static extern int BLUEBOX_FreeTagsMemory(ref int Handle, ref IntPtr Tags, int TagsNo);

        public int GetSwRelease(System.Text.StringBuilder SwRel)
        {
            return BLUEBOX_GetSwRelease(SwRel);
        }

        public int Init(out int Handle)
        {
            return BLUEBOX_Init(out Handle);
        }

        public int End(ref int Handle)
        {
            return BLUEBOX_End(ref Handle);
        }

        public int SetAddress(ref int Handle, byte Address)
        {
            return BLUEBOX_SetAddress(ref Handle, Address);
        }

        public int SetChannel(ref int Handle, String Channel, String Settings)
        {
            return BLUEBOX_SetChannel(ref Handle, Channel, Settings);
        }

        public int Open(ref int Handle)
        {
            return BLUEBOX_Open(ref Handle);
        }

        public int Close(ref int Handle)
        {
            return BLUEBOX_Close(ref Handle);
        }

        public int GetFwRelease(ref int Handle, int Reader, System.Text.StringBuilder FwRel)
        {
            return BLUEBOX_GetFwRelease(ref Handle, Reader, FwRel);
        }

        public int ReadParameters(ref int Handle, byte[] Parameters)
        {
            return BLUEBOX_ReadParameters(ref Handle, Parameters);
        }

        public int DataRequest(ref int Handle, out IntPtr Tags, out int TagsNo)
        {
            return BLUEBOX_DataRequest(ref Handle, out Tags, out TagsNo);
        }

        public int FreeTagsMemory(ref int Handle, ref IntPtr Tags, int TagsNo)
        {
            return BLUEBOX_FreeTagsMemory(ref Handle, ref Tags, TagsNo);
        }
    }
}
