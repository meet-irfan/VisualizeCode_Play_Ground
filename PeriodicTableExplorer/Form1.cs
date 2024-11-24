using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PeriodicTableExplorer
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Element> elements;
        private Label elementDetailsLabel; // Label to display element details

        public Form1()
        {
            InitializeComponent();

            // Initialize the form properties
            this.Text = "Periodic Table Explorer";
            this.Size = new Size(1500, 1000);
            this.BackColor = Color.Chocolate;

            // Initialize the Label for element details
            elementDetailsLabel = new Label
            {
                AutoSize = false,
                Size = new Size(400, 150),
                Location = new Point(900, 500), // Position the label on the right side
                Font = new Font("Arial", 12, FontStyle.Bold),
                BackColor = Color.Aqua,
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(20)
            };
            this.Controls.Add(elementDetailsLabel);

            InitializePeriodicTable();
        }

        private void InitializePeriodicTable()
        {
            // Dataset for elements
            elements = new Dictionary<string, Element>
            {
                { "Li", new Element("Lithium", "Li", 3, "Alkali Metal", "1s2 2s1") },
                { "Be", new Element("Beryllium", "Be", 4, "Alkaline Earth Metal", "1s2 2s2") },
                { "B", new Element("Boron", "B", 5, "Metalloid", "1s2 2s2 2p1") },
                { "C", new Element("Carbon", "C", 6, "Nonmetal", "1s2 2s2 2p2") },
                { "N", new Element("Nitrogen", "N", 7, "Nonmetal", "1s2 2s2 2p3") },
                { "O", new Element("Oxygen", "O", 8, "Nonmetal", "1s2 2s2 2p4") },
                { "F", new Element("Fluorine", "F", 9, "Halogen", "1s2 2s2 2p5") },
                { "Ne", new Element("Neon", "Ne", 10, "Noble Gas", "1s2 2s2 2p6") },
                { "Na", new Element("Sodium", "Na", 11, "Alkali Metal", "1s2 2s2 2p6 3s1") },
                { "Mg", new Element("Magnesium", "Mg", 12, "Alkaline Earth Metal", "1s2 2s2 2p6 3s2") },
                { "Al", new Element("Aluminium", "Al", 13, "Post-transition Metal", "1s2 2s2 2p6 3s2 3p1") },
                { "Si", new Element("Silicon", "Si", 14, "Metalloid", "1s2 2s2 2p6 3s2 3p2") },
                { "P", new Element("Phosphorus", "P", 15, "Nonmetal", "1s2 2s2 2p6 3s2 3p3") },
                { "S", new Element("Sulfur", "S", 16, "Nonmetal", "1s2 2s2 2p6 3s2 3p4") },
                { "Cl", new Element("Chlorine", "Cl", 17, "Halogen", "1s2 2s2 2p6 3s2 3p5") },
                { "Ar", new Element("Argon", "Ar", 18, "Noble Gas", "1s2 2s2 2p6 3s2 3p6") }
            };

            int buttonSize = 100;
            int spacing = 20;
            int xOffset = 20;
            int yOffset = 50;

            // Define colors for element categories
            var categoryColors = new Dictionary<string, Color>
            {
                { "Nonmetal", Color.LightGreen },
                { "Noble Gas", Color.LightSkyBlue },
                { "Alkali Metal", Color.LightSalmon },
                { "Alkaline Earth Metal", Color.LightYellow },
                { "Metalloid", Color.Plum },
                { "Halogen", Color.Orange },
                { "Post-transition Metal", Color.LightGray }
            };

            foreach (var element in elements)
            {
                // Create a button for each element
                Button elementButton = new Button
                {
                    Text = element.Key,
                    Size = new Size(buttonSize, buttonSize),
                    BackColor = categoryColors[element.Value.Category],
                    Tag = element.Value // Store the element data in the button's Tag property
                };

                // Define positions based on periodic table layout
                int col = GetElementColumn(element.Value.AtomicNumber); // Custom column logic
                int row = GetElementRow(element.Value.AtomicNumber);   // Custom row logic

                elementButton.Location = new Point(xOffset + col * (buttonSize + spacing), yOffset + row * (buttonSize + spacing));

                // Click event to show element details
                elementButton.Click += ElementButton_Click;

                this.Controls.Add(elementButton);
            }
        }

        // Displays details of the clicked element
        private void ElementButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            Element clickedElement = clickedButton.Tag as Element;

            // Display the element details on the Label
            elementDetailsLabel.Text =
                $"Name: {clickedElement.Name}\n" +
                $"Symbol: {clickedElement.Symbol}\n" +
                $"Atomic Number: {clickedElement.AtomicNumber}\n" +
                $"Category: {clickedElement.Category}\n" +
                $"Electron Configuration: {clickedElement.ElectronConfiguration}";
        }

        // Custom logic to determine column for periodic table layout
        private int GetElementColumn(int atomicNumber)
        {
            if (atomicNumber == 1) return 0; // Hydrogen in the first column
            if (atomicNumber == 2) return 17; // Helium in the last column
            if (atomicNumber >= 3 && atomicNumber <= 10) return (atomicNumber - 3) % 8 + 1; // Period 2
            if (atomicNumber >= 11 && atomicNumber <= 18) return (atomicNumber - 11) % 8 + 1; // Period 3
            return 0; // Placeholder for other elements
        }

        // Custom logic to determine row for periodic table layout
        private int GetElementRow(int atomicNumber)
        {
            if (atomicNumber == 1 || atomicNumber == 2) return 0; // Period 1
            if (atomicNumber >= 3 && atomicNumber <= 10) return 1; // Period 2
            if (atomicNumber >= 11 && atomicNumber <= 18) return 2; // Period 3
            return 0; // Placeholder for other elements
        }
    }

    // Element class to store element details
    public class Element
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public int AtomicNumber { get; set; }
        public string Category { get; set; }
        public string ElectronConfiguration { get; set; }

        public Element(string name, string symbol, int atomicNumber, string category, string electronConfiguration)
        {
            Name = name;
            Symbol = symbol;
            AtomicNumber = atomicNumber;
            Category = category;
            ElectronConfiguration = electronConfiguration;
        }
    }
}

