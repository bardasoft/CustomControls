using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class BuildingButtons : UserControl
    {
        public delegate void BuildingSelectEventHandler(string building);
        public BuildingButtons(Dictionary<string, string> buildings)
        {
            InitializeComponent();
            AddButtons(buildings);
        }

        private const int btnWidth = 155;
        private const int btnHeight = 35;
        private const int gap = 4;

        private int nextLoc = 10;

        public event BuildingSelectEventHandler SelectBuildingEvent;
        public void SelectBuilding(string building)
        {
            if (SelectBuildingEvent != null)
                SelectBuildingEvent(building);
        }

        private void AddButtons(Dictionary<string, string> buildings)
        {
            Height += (btnHeight + gap) * buildings.Count;

            foreach (var buildingText in buildings.Values)
            {
                nextLoc += btnHeight + gap;
                Button buildingBtn = new Button();
                Controls.Add(buildingBtn);
                buildingBtn.Size = new Size(btnWidth, btnHeight);
                buildingBtn.Location = new Point(10, nextLoc);
                buildingBtn.FlatStyle = FlatStyle.Flat;
                buildingBtn.FlatAppearance.BorderColor = Color.Silver;
                buildingBtn.Text = buildingText;
                buildingBtn.Click += ChangeBuilding;
            }
        }

        private void ChangeBuilding(object sender, EventArgs e)
        {
            string buildingText = ((Button)sender).Text;
            SelectBuilding(buildingText);
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            SelectBuilding("전체");
        }
    }
}
