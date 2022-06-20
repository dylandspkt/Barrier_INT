using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace BLUEBOX_Polling
{
    interface BLUEBOXLibInterface
    {
        int GetSwRelease(System.Text.StringBuilder SwRel);

        int Init(out int Handle);

        int End(ref int Handle);

        int SetAddress(ref int Handle, byte Address);

        int SetChannel(ref int Handle, String Channel, String Settings);

        int Open(ref int Handle);

        int Close(ref int Handle);

        int GetFwRelease(ref int Handle, int Reader, System.Text.StringBuilder FwRel);

        int ReadParameters(ref int Handle, byte[] Parameters);

        int DataRequest(ref int Handle, out IntPtr Tags, out int TagsNo);

        int FreeTagsMemory(ref int Handle, ref IntPtr Tags, int TagsNo);
    }
}
