using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightAnimationGUICsharp
{
    public partial class LightAnimator4Pi : Form
    {
        private PinData[] pinDatas = new PinData[32];
        private PinData selectedPinData;

        private int frameInt;

        private List<string> logs = new List<string>();

        public LightAnimator4Pi()
        {
            InitializeComponent();
            //whichpi.Items.Add("custom");

            SupportedPis[] values = (SupportedPis[])Enum.GetValues(typeof(SupportedPis));

            for (int i = 0; i < values.Length; i++)
            {
                SupportedPis supported = values[i];
                whichpi.Items.Add(supported.ToString());
            }

            for (int i = 0; i < pinDatas.Length; i++)
            {
                PinData pinData = new PinData(i);
                pinDatas[i] = pinData;
            }

            frameInt = (int)frame.Value;

            selectedPinData = pinDatas[(int)selectedpin.Value];

            selectedPinData.GetFrames().Add(new PinData.FrameData(frameInt, PinData.Pinmode.OFF));

            whichpi.SelectedIndex = 0;
            fps.Value = 10;

            logBox.Scrollable = true;


            statusLabel.Text = "The current status is not set";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            selectedPinData = pinDatas[(int)selectedpin.Value];
            updateLog();
        }

        private void frame_ValueChanged(object sender, EventArgs e)
        {

            frameInt = (int)frame.Value - 1;

            int frameTime = frameInt + 1;

            frame.Maximum = decimal.MaxValue;



            if (selectedPinData.GetFrames().ToArray().Length < frameTime)
            {
                int times = frameTime - selectedPinData.GetFrames().ToArray().Length;


                for (int i = 0; i < times; i++)
                {
                    int newFrame = frameTime - i;
                    selectedPinData.GetFrames().Add(new PinData.FrameData(newFrame, PinData.Pinmode.OFF));
                }


            }

            if (frameInt < 0) frameInt = 0;

            PinData.FrameData frameData = selectedPinData.GetFrames()[frameInt];
            updateFrame(frameData);
        }

        private void fps_ValueChanged(object sender, EventArgs e)
        {
            fps.Maximum = decimal.MaxValue;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SupportedPis selectedPi = ParseEnum<SupportedPis>(whichpi.SelectedItem.ToString());

            selectedpin.Maximum = AllPins(selectedPi);
        }

        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public enum SupportedPis
        {
            CUSTOM,
            //------------------------
            RaspberryPi_A,
            RaspberryPi_B_Rev1,
            RaspberryPi_B_Rev2,
            RaspberryPi_A_Plus,
            RaspberryPi_B_Plus,
            RaspberryPi_ComputeModule,
            RaspberryPi_2B,
            RaspberryPi_3B,
            RaspberryPi_3B_Plus,
            RaspberryPi_Zero,
            RaspberryPi_ComputeModule3,
            RaspberryPi_ZeroW,
            RaspberryPi_Alpha,
            RaspberryPi_Unknown,
            //------------------------
            // (LEMAKER BANANAPI)
            BananaPi,
            BananaPro,
            //------------------------
            // (SINOVOIP BANANAPI)  (see: https://github.com/BPI-SINOVOIP/WiringPi/blob/master/wiringPi/wiringPi_bpi.c#L1318)
            Bpi_M1,
            Bpi_M1P,
            Bpi_M2,
            Bpi_M2P,
            Bpi_M2P_H2_Plus,
            Bpi_M2P_H5,
            Bpi_M2U,
            Bpi_M2U_V40,
            Bpi_M2M,
            Bpi_M3,
            Bpi_R1,
            Bpi_M64,
            //------------------------
            Odroid,
            //------------------------
            OrangePi,
            //------------------------
            NanoPi_M1,
            NanoPi_M1_Plus,
            NanoPi_M3,
            NanoPi_NEO,
            NanoPi_NEO2,
            NanoPi_NEO2_Plus,
            NanoPi_NEO_Air,
            NanoPi_S2,
            NanoPi_A64,
            NanoPi_K2
            //------------------------
        }

        // *override* static method from subclass
        // (overriding a static method is not supported in Java
        //  so this method definition will hide the subclass static method)
        public int AllPins(SupportedPis supportedPi)
        {
            int max;
            max = 16;

            // no further pins to add for Model B Rev 1 boards
            if (supportedPi == SupportedPis.RaspberryPi_B_Rev1)
            {
                // return pins collection
                return max;
            }

            // add pins exclusive to Model A and Model B (Rev2)
            if (supportedPi == SupportedPis.RaspberryPi_A ||
               supportedPi == SupportedPis.RaspberryPi_B_Rev2)
            {
                max = 20;
            }

            // add pins exclusive to Models A+, B+, 2B, 3B, and Zero
            else
            {
                max = 31;
            }

            // return pins collection
            return max;
        }

        private void onPin_Click(object sender, EventArgs e)
        {
            statusLabel.Text = selectedPinData.GetFrames().ToArray().Length.ToString();
            PinData.FrameData frameData = selectedPinData.GetFrames()[frameInt];

            updateFrame(frameData, true);
        }

        private void offPin_Click(object sender, EventArgs e)
        {
            PinData.FrameData frameData = selectedPinData.GetFrames()[frameInt];

            updateFrame(frameData, false);
        }

        private void updateFrame(PinData.FrameData frameData, bool status)
        {
            if (status)
            {
                frameData.setPinMode(PinData.Pinmode.ON);
            }
            else
            {
                frameData.setPinMode(PinData.Pinmode.OFF);
            }

            updateFrame(frameData);

        }
        private void updateFrame(PinData.FrameData frameData)
        {
            if (frameData.GetPinmode().Equals(PinData.Pinmode.ON))
            {
                statusLabel.Text = "The current status is on";
            }
            else
            {
                statusLabel.Text = "The current status is off";
            }
            updateLog();
        }

        public void updateLog()
        {
            logBox.Clear();

            for (int i = 0; i < selectedPinData.GetFrames().ToArray().Length; i++)
            {
                PinData.FrameData frameData = selectedPinData.GetFrames()[i];
                logBox.Items.Add("Frame" + frameData.getFrame() + " is " + frameData.GetPinmode().ToString());
            }
        }



        private void save(string filepath)
        {

            int pins = 0;
            foreach (PinData pinData in pinDatas)
            {
                if (pins > selectedpin.Maximum) break;

                pins++;

                List<string> lines = new List<string>();
                PinData.Pinmode lastPinMode = PinData.Pinmode.OFF;
                bool run = false;

                bool toSleep = false;
                decimal sleep = 0;



                foreach (PinData.FrameData frameData in pinData.GetFrames())
                {

                    string line = "pin " + pinData.getId() + " " + frameData.GetPinmode().ToString();

                    if (!run)
                    {
                        run = true;
                        lastPinMode = frameData.GetPinmode();
                        lines.Add(line);
                        continue;
                    }

                    if (lastPinMode == frameData.GetPinmode() && run)
                    {
                        Console.WriteLine("check 2 " + fps.Value / 1000);
                        sleep += fps.Value / 1000;

                        toSleep = true;
                        continue;
                    }

                    lastPinMode = frameData.GetPinmode();

                    if (toSleep)
                    {
                        string oldline = line;
                        line = "sleep " + sleep;
                        sleep = 0;
                        toSleep = false;

                        lines.Add(line);
                        lines.Add(oldline);
                        continue;
                    }
                    Console.WriteLine("check 5 " + line);
                    lines.Add(line);
                }

                if (toSleep)
                {
                    string line = "sleep " + sleep;
                    sleep = 0;
                    toSleep = false;

                    lines.Add(line);
                }




               /* Console.WriteLine(lines.ToArray().ToString());
                logBox.Clear();

                for (int i = 0; i < lines.ToArray().Length; i++)
                {
                    logBox.Items.Add(lines[i]);
                }*/


                    using (System.IO.StreamWriter file =
                        new System.IO.StreamWriter(@filepath + "\\" + pinData.getId().ToString() + ".pia"))
                    {
                        foreach (string line in lines)
                        {
                            // If the line doesn't contain the word 'Second', write the line to the file.

                            file.WriteLine(line);

                        }
                    }
                




            }


        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            bool openFolderDial = false;
            if (savePath.Text == "")
            {
                openFolderDial = true;
            }
            else
            {
                try
                {
                    Path.GetDirectoryName(savePath.Text);
                    if(!Directory.Exists(savePath.Text))
                    {
                        openFolderDial = true;
                    }
                }
                catch (ArgumentException ex)
                {
                    openFolderDial = true;
                }
                catch (PathTooLongException ex)
                {
                    openFolderDial = true;
                }

                if (!openFolderDial)
                {
                    save(savePath.Text);
                }
            }

            if (openFolderDial && folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                savePath.Text = folderBrowserDialog1.SelectedPath;
                save(folderBrowserDialog1.SelectedPath);
            }

        }

        private void logBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (logBox.SelectedItems.Count > 0)
            {
                string selected = logBox.SelectedItems[0].Text;

                string result1 = selected.Split(new[] { "Frame" }, StringSplitOptions.None)[1];
                string result = result1.Split(new[] { " is" }, StringSplitOptions.None)[0];



                frame.Value = decimal.Parse(result);
            }
        }

    }

    public class PinData
    {
        private int id;
        private readonly List<FrameData> frameDatas = new List<FrameData>();

        public PinData(int id)
        {
            this.id = id;
        }

        public List<FrameData> GetFrames()
        {
            return frameDatas;
        }

        public int getId()
        {
            return id;
        }


        public class FrameData {
            private readonly int frame;
            private Pinmode pinmode;

            public FrameData(int frame, Pinmode pinm)
            {
                this.frame = frame;
                this.pinmode = pinm;

            }

            public Pinmode GetPinmode()
            {
                return pinmode;
            }

            public int getFrame()
            {
                return frame;
            }

            public void setPinMode(Pinmode pinmode)
            {
                this.pinmode = pinmode;
            }
        }


        public enum Pinmode
        {
            ON,
            OFF
        }
    }
}
