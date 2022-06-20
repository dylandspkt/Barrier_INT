using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;
using System.Threading;

namespace BLUEBOX_Polling
{
    public partial class MainForm : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct BLUEBOX_Tag
        {
            internal int TagType;
            internal IntPtr Id;
            internal int Length;
            internal int Antenna;
            internal int Input;
        };

        /// <summary>
        /// The BLUEBOX library to use the correct library in accordance with the target platform.
        /// </summary>
        private BLUEBOXLibInterface BLUEBOXLib;

        /// <summary>
        /// Array to store the library handle.
        /// </summary>
        private int [] HandleArray = new int [0];

        /// <summary>
        /// Thread acquisition variable.
        /// </summary>
        private Thread [] t = new Thread [0];

        /// <summary>
        /// Flag to control the thread acquisition.
        /// </summary>
        private bool [] ThreadRun = new bool [0];

        /// <summary>
        /// Delegate to avoid cross thread exception error in communication thread.
        /// </summary>
        private delegate void ThreadAcquisitionCallBack_0p ();

        /// <summary>
        /// Delegate to avoid cross thread exception error in communication thread.
        /// </summary>
        private delegate void ThreadAcquisitionCallBack_1p(System.Object Obj);

        /// <summary>
        /// Class constructor.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            if (IntPtr.Size == 8)
            {
                BLUEBOXLib = new BLUEBOXLibClass_x64();
            }
            else if (IntPtr.Size == 4)
            {
                BLUEBOXLib = new BLUEBOXLibClass_x32();
            }
            else
            {
            }
        }

        /// <summary>
        /// About menu item click event. Show the about box.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox AboutForm = new AboutBox();
            AboutForm.ShowDialog();
        }

		/// <summary>
		/// Add a row to data request data grid view table. This function also checks if the row already exist or no and update a counter.
        /// <param name="Row">Row to add to the data grid view.</param>
		/// <\summary>
		private void AddDataRequestTable (System.Object Row)
		{
            // Flag to use in search.
            bool RowFound = false;
            // Search in data grid view.
            for (int RowIndex = 0; RowIndex < this.TagDataGridView.Rows.Count; RowIndex++)
            {
                if ((this.TagDataGridView[this.DeviceColumn.Index,RowIndex].Value.ToString() == ((string[])Row)[0]) &&
                    (this.TagDataGridView[this.AntennaColumn.Index, RowIndex].Value.ToString() == ((string[])Row)[1]) &&
                    (this.TagDataGridView[this.InputColumn.Index, RowIndex].Value.ToString() == ((string[])Row)[2]) &&
                    (this.TagDataGridView[this.TagTypeColumn.Index, RowIndex].Value.ToString() == ((string[])Row)[3]) &&
                    (this.TagDataGridView[this.IdColumn.Index, RowIndex].Value.ToString() == ((string[])Row)[4]))
                {
                    // Flag found.
                    RowFound = true;
                    // Update counter.
                    int Count = Convert.ToInt32(this.TagDataGridView[this.CountColumn.Index, RowIndex].Value);
                    this.TagDataGridView[this.CountColumn.Index, RowIndex].Value = ++Count;
                }
            }

            if (!RowFound) { this.TagDataGridView.Rows.Add((string[])Row); }
		}

        /// <summary>
        /// Thread acquisition that controls the readers polling.
        /// </summary>
        private void ThreadAcquisition()
        {

            try
            {
                while (ThreadRun[Convert.ToInt32(Thread.CurrentThread.Name)])
                {
                    int ThreadIndex = Convert.ToInt32(Thread.CurrentThread.Name);

                    try
                    {
                        // set variables for tags number
                        int TagsNo;
                        IntPtr Tags = IntPtr.Zero;
                        // read the datas from reader
                        int Err = BLUEBOXLib.DataRequest(ref HandleArray[ThreadIndex], out Tags, out TagsNo);                        

                        if (Err == 0)
                        {
                            // print the tags read
                            for (int Index = 0; Index < TagsNo; Index++)
                            {
                                // pointer to the buffer that contains data received from the call of data request
                                IntPtr Tmp = new IntPtr((int)Tags + (Index * Marshal.SizeOf(typeof(BLUEBOX_Tag))));
                                // now got the pointer to the struct, get the structure from the memory
                                BLUEBOX_Tag Tag = (BLUEBOX_Tag)Marshal.PtrToStructure(Tmp, typeof(BLUEBOX_Tag));
                                // create the strings array for antenna and id
                                string Antenna = (Convert.ToString(Tag.Antenna));
                                string Input = (Convert.ToString(Tag.Input));

                                string TagType = "-";

                                switch (Tag.TagType)
                                {
                                    case 1:
                                        TagType = "BLUEBOX SHORT";
                                        break;
                                    case 2:
                                        TagType = "BLUEBOX MEDIUM";
                                        break;
                                    case 3:
                                        TagType = "BLUEBOX LARGE";
                                        break;
                                    case 8:
                                        TagType = "ISO 14443A";
                                        break;
                                    case 9:
                                        TagType = "MIFARE 1k";
                                        break;
                                    case 10:
                                        TagType = "MIFARE 4k";
                                        break;
                                    case 11:
                                        TagType = "MIFARE Ultralight";
                                        break;
                                    case 12:
                                        TagType = "ISO 15693";
                                        break;
                                    case 13:
                                        TagType = "ICODE SLI";
                                        break;
                                    case 14:
                                        TagType = "Tag-It HF-I";
                                        break;
                                    case 15:
                                        TagType = "EM4035";
                                        break;
                                    case 16:
                                        TagType = "LRI 64/512";
                                        break;
                                    case 17:
                                        TagType = "MB89R118";
                                        break;
                                    case 18:
                                        TagType = "ISO 14443B";
                                        break;
                                    case 19:
                                        TagType = "SR176";
                                        break;
                                    case 20:
                                        TagType = "ISO 18000-6B";
                                        break;
                                    case 21:
                                        TagType = "ISO 18000-6C";
                                        break;
                                    case 22:
                                        TagType = "ACTIVE";
                                        break;
                                    case 23:
                                        TagType = "EM4035";
                                        break;
                                    case 24:
                                        TagType = "T5557";
                                        break;
                                    case 25:
                                        TagType = "ICODE SLI-S";
                                        break;
                                }

                                string Id = "";
                                for (int k = 0; k < Tag.Length; k++)
                                {
                                    Id += Marshal.ReadByte(Tag.Id, k).ToString("X2").ToUpper() + " ";
                                }

                                // create the row to add to the table
                                Array Row = new string[] { ThreadIndex.ToString(), Antenna, Input, TagType, Id, "0" };
                                // add the row to the table
                                this.Invoke(new ThreadAcquisitionCallBack_1p(AddDataRequestTable), Row);
                            }
                            // free the allocated buffer from the reader
                            Err = BLUEBOXLib.FreeTagsMemory(ref HandleArray[ThreadIndex], ref Tags, TagsNo);

                            Thread.Sleep(10);
                        }

                        switch (Err)
                        {
                            case 0:
                                break;
                            case -2:
                                MessageBox.Show("BLUEBOXLib.dll: Invalid handle!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -4:
                                MessageBox.Show("BLUEBOXLib.dll: Invalid parameters!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -5:
                                MessageBox.Show("BLUEBOXLib.dll: Generic error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -6:
                                MessageBox.Show("BLUEBOXLib.dll: Timeout error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -7:
                                MessageBox.Show("BLUEBOXLib.dll: Communication error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -8:
                                MessageBox.Show("BLUEBOXLib.dll: Connection error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -9:
                                MessageBox.Show("BLUEBOXLib.dll: Memory allocation error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -10:
                                MessageBox.Show("BLUEBOXLib.dll: Invalid command!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            case -11:
                                // tag not found
                                Err = 0;
                                break;
                            case -12:
                                // tag error
                                Err = 0;
                                break;
                            default:
                                MessageBox.Show("BLUEBOXLib.dll: Internal error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                        }

                        if (Err != 0)
                        {
                            for (int RowIndex = 0; RowIndex < this.DeviceDataGridView.RowCount - 1; RowIndex++)
                            {
                                ThreadRun[RowIndex] = false;
                            }
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        for (int RowIndex = 0; RowIndex < this.DeviceDataGridView.RowCount - 1; RowIndex++)
                        {
                            ThreadRun[RowIndex] = false;
                        }
                    }
                }

                try
                {
                    int ThreadIndex = Convert.ToInt32(Thread.CurrentThread.Name);

                    // close the connection
                    BLUEBOXLib.Close(ref HandleArray[ThreadIndex]);
                    // free library resources
                    BLUEBOXLib.End(ref HandleArray[ThreadIndex]);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Invoke(new ThreadAcquisitionCallBack_0p(this.ClosingConnection));
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Start acquisition button click event. Start the acquisition thread.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (this.DeviceDataGridView.RowCount > 1)
            {
                int Err = 0, RowIndex;
                byte Address;

                for (RowIndex = 0; RowIndex < this.DeviceDataGridView.RowCount - 1; RowIndex++)
                {
                    // ok, there are devices in table
                    try
                    {
                        Address = Convert.ToByte(this.DeviceDataGridView[this.AddressColumn.Index, RowIndex].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Type a valid device address (0 - 255)!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        // end all the library handles created
                        for (int Index = 0; Index < RowIndex; Index++)
                        {
                            BLUEBOXLib.Close(ref HandleArray[Index]);
                            BLUEBOXLib.End(ref HandleArray[Index]);
                        }
                        return;
                    }

                    // check the ip address in the data grid view
                    try
                    {
                        IPAddress Ip = IPAddress.Parse(this.DeviceDataGridView[this.IpColumn.Index, RowIndex].Value.ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Type a valid IP address!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        // end all the library handles created
                        for (int Index = 0; Index < RowIndex; Index++)
                        {
                            BLUEBOXLib.Close(ref HandleArray[Index]);
                            BLUEBOXLib.End(ref HandleArray[Index]);
                        }
                        return;
                    }

                    // check the port
                    try
                    {
                        UInt16 Port = Convert.ToUInt16(this.DeviceDataGridView[this.PortColumn.Index, RowIndex].Value);
                    }
                    catch
                    {
                        MessageBox.Show("Type a valid port number (1 - 65535)!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);

                        // end all the library handles created
                        for (int Index = 0; Index < RowIndex; Index++)
                        {
                            BLUEBOXLib.Close(ref HandleArray[Index]);
                            BLUEBOXLib.End(ref HandleArray[Index]);
                        }
                        return;
                    }

                    try
                    {
                        // resize the handle array
                        Array.Resize(ref HandleArray, HandleArray.Length + 1);
                        // try to init. the library
                        Err = BLUEBOXLib.Init(out HandleArray[RowIndex]);

                        // check library initialization
                        if (Err != 0)
                        {
                            MessageBox.Show("BLUEBOXLib.dll: Library load error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // end all the library handles created
                            for (int Index = 0; Index < RowIndex; Index++)
                            {
                                BLUEBOXLib.Close(ref HandleArray[Index]);
                                BLUEBOXLib.End(ref HandleArray[Index]);
                            }
                            return;
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // end all the library handles created
                        for (int Index = 0; Index < RowIndex; Index++)
                        {
                            BLUEBOXLib.Close(ref HandleArray[Index]);
                            BLUEBOXLib.End(ref HandleArray[Index]);
                        }
                        return;
                    }

                    try
                    {
                        // try to set address
                        Err = BLUEBOXLib.SetAddress(ref HandleArray[RowIndex], Address);

                        if (Err == 0)
                        {
                            // create the settings string to pass to library
				            System.String strSettings = this.DeviceDataGridView[this.IpColumn.Index,RowIndex].Value.ToString() + ":" + this.DeviceDataGridView[this.PortColumn.Index,RowIndex].Value.ToString() + ",60000";

                            Err = BLUEBOXLib.SetChannel(ref HandleArray[RowIndex], "TCP", strSettings);
                        }

                        if (Err != 0)
                        {
                            MessageBox.Show("BLUEBOXLib.dll: Library initialization error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // end all the library handles created
                            for (int Index = 0; Index < RowIndex; Index++)
                            {
                                BLUEBOXLib.Close(ref HandleArray[Index]);
                                BLUEBOXLib.End(ref HandleArray[Index]);
                            }

                            // also release this library handle
                            BLUEBOXLib.End(ref HandleArray[RowIndex]);
                            return;
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // end all the library handles created
                        for (int Index = 0; Index < RowIndex; Index++)
                        {
                            BLUEBOXLib.Close(ref HandleArray[Index]);
                            BLUEBOXLib.End(ref HandleArray[Index]);
                        }

                        // also release this library handle
                        BLUEBOXLib.End(ref HandleArray[RowIndex]);
                        return;
                    }

                    try
                    {
                        // open the connection
                        Err = BLUEBOXLib.Open(ref HandleArray[RowIndex]);

                        if (Err != 0)
                        {
                            MessageBox.Show("BLUEBOXLib.dll: Connection error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // end all the library handles created
                            for (int Index = 0; Index < RowIndex; Index++)
                            {
                                BLUEBOXLib.Close(ref HandleArray[Index]);
                                BLUEBOXLib.End(ref HandleArray[Index]);
                            }

                            // also release this library handle
                            BLUEBOXLib.End(ref HandleArray[RowIndex]);
                            return;
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // end all the library handles created
                        for (int Index = 0; Index < RowIndex; Index++)
                        {
                            BLUEBOXLib.Close(ref HandleArray[Index]);
                            BLUEBOXLib.End(ref HandleArray[Index]);
                        }

                        // also release this library handle
                        BLUEBOXLib.End(ref HandleArray[RowIndex]);
                        return;
                    }

                    try
                    {
                        // Read the firmware version.
                        System.Text.StringBuilder FwRel = new StringBuilder(64);

                        Err = BLUEBOXLib.GetFwRelease(ref HandleArray[RowIndex], 0, FwRel);

                        if (Err == 0)
                        {
                            this.DeviceDataGridView[this.FwRelColumn.Index, RowIndex].Value = FwRel.ToString(0, 16);
                        }
                        else
                        {                            
                            MessageBox.Show("BLUEBOXLib.dll: Communication error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // End all the library handles created.
                            for (int Index = 0; Index < RowIndex; Index++)
                            {
                                BLUEBOXLib.Close(ref HandleArray[Index]);
                                BLUEBOXLib.End(ref HandleArray[Index]);
                            }

                            // Also release this library handle.
                            BLUEBOXLib.Close(ref HandleArray[RowIndex]);
                            BLUEBOXLib.End(ref HandleArray[RowIndex]);
                            return;
                        }

                        // Read the general parameters.
                        byte[] Params = new byte[7];

                        Err = BLUEBOXLib.ReadParameters(ref HandleArray[RowIndex], Params);

                        if (Err == 0)
                        {
                        }
                        else
                        {
                            MessageBox.Show("BLUEBOXLib.dll: Communication error!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // End all the library handles created.
                            for (int Index = 0; Index < RowIndex; Index++)
                            {
                                BLUEBOXLib.Close(ref HandleArray[Index]);
                                BLUEBOXLib.End(ref HandleArray[Index]);
                            }

                            // Also release this library handle.
                            BLUEBOXLib.Close(ref HandleArray[RowIndex]);
                            BLUEBOXLib.End(ref HandleArray[RowIndex]);
                            return;
                        }
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // End all the library handles created.
                        for (int Index = 0; Index < RowIndex; Index++)
                        {
                            BLUEBOXLib.Close(ref HandleArray[Index]);
                            BLUEBOXLib.End(ref HandleArray[Index]);
                        }

                        // Also release this library handle.
                        BLUEBOXLib.Close(ref HandleArray[RowIndex]);
                        BLUEBOXLib.End(ref HandleArray[RowIndex]);
                        return;
                    }
                }

                try
                {
                    // Resize arrays.
                    Array.Resize(ref t, this.DeviceDataGridView.RowCount - 1);
                    Array.Resize(ref ThreadRun, this.DeviceDataGridView.RowCount - 1);

                    // Create the acquisition threads.
                    for (RowIndex = 0; RowIndex < this.DeviceDataGridView.RowCount - 1; RowIndex++)
                    {
                        t[RowIndex] = new Thread(new ThreadStart(this.ThreadAcquisition));
                        // Set the thread name.
                        t[RowIndex].Name = RowIndex.ToString();
                        // Flag thread running.
                        ThreadRun[RowIndex] = true;
                        // Set the english culture as current culture.
                        t[RowIndex].CurrentCulture = new System.Globalization.CultureInfo("en-GB");
                        t[RowIndex].CurrentUICulture = new System.Globalization.CultureInfo("en-GB");
                        // Start the acquisition thread.
                        t[RowIndex].Start();
                    }      
                  
                    // Manage controls.
                    this.OpeningConnection();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // End all the library handles created.
                    for (int Index = 0; Index < RowIndex; Index++)
                    {
                        BLUEBOXLib.Close(ref HandleArray[Index]);
                        BLUEBOXLib.End(ref HandleArray[Index]);
                    }

                    // Also release this library handle.
                    BLUEBOXLib.Close(ref HandleArray[RowIndex]);
                    BLUEBOXLib.End(ref HandleArray[RowIndex]);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Must be at least one device in device table!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        /// <summary>
        /// Stop acquisition button click event. Stop the acquisition thread.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int RowIndex = 0; RowIndex < this.DeviceDataGridView.RowCount - 1; RowIndex++)
                {
                    ThreadRun[RowIndex] = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n\n" + Ex.ToString(), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Manage controls enable status on opening connection event.
        /// </summary>
        private void OpeningConnection()
        {
            this.DeviceDataGridView.Enabled = false;
            this.StartButton.Enabled = false;
            this.StopButton.Enabled = true;

            this.TagDataGridView.Rows.Clear();
        }

        /// <summary>
        /// Manage controls enable status on closing connection event.
        /// </summary>
        private void ClosingConnection()
        {
            this.DeviceDataGridView.Enabled = true;
            this.StartButton.Enabled = true;
            this.StopButton.Enabled = false;
        }

        /// <summary>
        /// Exit menu item button click event. Close the application.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Form closing event. Check the acquisition, if running abort the operation.
        /// </summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Arguments of the event.</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check the acquisition, if running abort the operation.
            if (StopButton.Enabled)
            {
                MessageBox.Show("Acquisition is running.\n\nStop the acquisition before closing the application", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
    }
}