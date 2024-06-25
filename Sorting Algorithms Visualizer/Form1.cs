using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;


namespace Sorting_Algorithms_Visualizer
{
    public partial class Form1 : Form
    {
        // Initialize array and graphics variables
        int[] arr;
        Graphics g;
        BackgroundWorker worker = null;
        bool isPaused = false;

        public Form1()
        {
            InitializeComponent();
            PopulateDropdown();
        }

        // Populate dropdown list with algorithms
        private void PopulateDropdown()
        {
            List<string> ClassList = AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                .Where(x => typeof(SortingLogic).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                .Select(x => x.Name).ToList();

            ClassList.Sort();
            foreach (string c in ClassList)
            {
                comboBox.Items.Add(c);
            }
            comboBox.SelectedIndex = 0;
        }

        // Reset panel
        private void button1_Click(object sender, EventArgs e)
        {
            // Create graphics and initialize size variables
            g = panel1.CreateGraphics();
            int x_values = panel1.Width;
            int y_max = panel1.Height;

            // Create array of size x and add graphics
            Random r = new Random(x_values);
            arr = new int[x_values];
            g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, x_values, y_max);

            // Randomize values
            for (int i = 0; i < x_values; i++)
            {
                arr[i] = r.Next(0, y_max);
            }

            // Add color to each element
            for (int i = 0; i < x_values; i++)
            {
                g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, y_max - arr[i], 1, y_max);
            }
        }

        // Run selected algorithm
        private void Play_Click(object sender, EventArgs e)
        {
            if (arr == null) button1_Click(null, null);

            // Setup background worker and run
            worker = new BackgroundWorker();
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerAsync(argument: comboBox.SelectedItem);
        }

        // Region for background worker data
        #region workerData

        public void worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            // Worker Data
            BackgroundWorker bw = sender as BackgroundWorker;
            string runAlgorithm = (string)e.Argument;
            Type type = Type.GetType("Sorting_Algorithms_Visualizer." + runAlgorithm);
            var constructors = type.GetConstructors();

            // Error Handling
            try
            {
                SortingLogic SL = (SortingLogic)constructors[0].Invoke(new object[] { arr, g, panel1.Height });
                while (!SL.isSorted() && (!worker.CancellationPending)) { SL.adjacent(); }
            } catch (Exception exc) {}
        }

        // Pausing/Resuming running of algorithm
        private void Pause_Click(object sender, EventArgs e)
        {
            // Pausing
            if (!isPaused)
            {
                worker.CancelAsync();
                isPaused = true;
            }
            // Resuming
            else
            {
                int x_values = panel1.Width;
                int y_max = panel1.Height;
                isPaused = false;
                
                for (int i = 0; i < x_values; i++)
                {
                    g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), i, 0, 1, y_max);
                    g.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, y_max - arr[i], 1, y_max);
                }
                worker.RunWorkerAsync(argument: comboBox.SelectedItem);
            }
        }

        #endregion

        // Exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Redirect to GitHub page once clicked
        protected void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://www.github.com/Shshiv0",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        // Redirect to GitHub repository once clicked
        private void repositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/Shshiv0/Sort-Visualizer",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }
    }
}
