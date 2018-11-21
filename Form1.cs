using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;


namespace Client
{

    

    public partial class Form1 : Form
    {
   
        Fighters_DatabaseEntities db = new Fighters_DatabaseEntities();

        public Form1()
        {
         
          
            InitializeComponent();

            var query = from promoution in db.Promoutions
              
                 /* from fighter in db.Fighters
                        join promoution in db.Promoutions on fighter.Promoution_Id equals promoution.Promoutions_Id
                        join weight in db.Weight_Classes on fighter.Weight_Id equals weight.Weight_Id
                          orderby fighter.Age
                         select new
                         {
                             promoution.Promoutions_Name
                         };*/
                        select promoution.Promoutions_Name;

            var listFromQuery = query.ToList();
            boxForPromoution.DataSource = listFromQuery;
            listFromQuery.ElementAt(3);


            var queryForWeight = from weight in db.Weight_Classes
                                 select weight.Name_of_weight_class;

            var listFromqueryForWeight = queryForWeight.ToList();
            comboBoxForWeight.DataSource = listFromqueryForWeight; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            var db = new Fighters_DatabaseEntities();
            var query = from b in db.Fighters
                        orderby b.Age
                        select b;
            var Fighter = query.ToArray();
            var JonJones = Fighter[0];
            this.Text = JonJones.Name;
            //this.Hide();//прячем это окно
            */
            // Form2 f = new Form2();
            // f.Show();

    }



        public void FirstFunc()
        {
           
        }

        private void TextBoxChanged(object sender, EventArgs e)
        {

                int numz;


                var heightFrom = int.TryParse(text_box_for_height_from.Text, out numz) ? numz : 0;// string.IsNullOrEmpty(text_box_for_height_from.Text)? 0 : Convert.ToInt32(text_box_for_height_from.Text);
                var heightTo = int.TryParse(text_box_for_height_to.Text, out numz) ? numz : 260;
                var reachHandFrom = int.TryParse(boxForReachFrom.Text, out numz) ? numz : 0;
                var reacHandTo = int.TryParse(boxForReachto.Text, out numz) ? numz : 350;
                double num;
                string candidate = textBoxForAgeTo.Text;
                 if (double.TryParse(candidate, out num))
                    {
                          // It's a number!
                    }


                var YearsFrom = int.TryParse(text_box_for_age.Text, out numz) ? numz : 0;
                var YearsTo = int.TryParse(textBoxForAgeTo.Text, out numz) ? numz : 150;
                var promoutionNameFromBox = boxForPromoution.Text;
                var weightCategoryNameBox = comboBoxForWeight.Text;


                int promoution_idd = 0;
                switch (promoutionNameFromBox)
                {
                    case "UFC":
                        promoution_idd = 1;
                        break;

                    case "Bellator":
                        promoution_idd = 2;
                        break;

                    case "WSOF":
                        promoution_idd = 3;
                        break;

                    case "M1":
                        promoution_idd = 4;
                        break;

                    case "Berkut":
                        promoution_idd = 5;
                        break;

                    case "Pride":
                        promoution_idd = 6;
                        break;
                }

                int weight_id = 0;
                switch (weightCategoryNameBox)
                {
                    case "FLYWEIGHT":
                        weight_id = 1;
                        break;

                    case "BANTAMWEIGHT":
                        weight_id = 2;
                        break;

                    case "FEATHERWEIGHT":
                        weight_id = 3;
                        break;

                    case "LIGHTWEIGHT":
                        weight_id = 4;
                        break;

                    case "WELTERWEIGHT":
                        weight_id = 5;
                        break;

                    case "MIDDLEWEIGHT":
                        weight_id = 6;
                        break;

                    case "LIGHT HEAVYWEIGHT":
                        weight_id = 7;
                        break;

                    case "HEAVYWEIGHT":
                        weight_id = 8;
                        break;
                }



            var query = from fighter in db.Fighters
                        join promoution in db.Promoutions on fighter.Promoution_Id equals promoution.Promoutions_Id
                        join weight in db.Weight_Classes on fighter.Weight_Id equals weight.Weight_Id
                        where (string.IsNullOrEmpty(text_box_for_name.Text) ? fighter.Name != string.Empty : fighter.Name.StartsWith(text_box_for_name.Text)) &&
                 (string.IsNullOrEmpty(text_box_for_surname.Text) ? fighter.Surname != string.Empty : fighter.Surname.StartsWith(text_box_for_surname.Text)) &&
                (fighter.Age > YearsFrom && fighter.Age < YearsTo) &&
                  (fighter.Height_in_cm > heightFrom) && (fighter.Height_in_cm < heightTo)
                  &&
                 (string.IsNullOrEmpty(boxForPromoution.Text) ? fighter.Promoution_Id != 0 : fighter.Promoution_Id == promoution_idd) &&
                 (string.IsNullOrEmpty(comboBoxForWeight.Text) ? fighter.Weight_Id != 0 : fighter.Weight_Id == weight_id) &&
                 (fighter.Reach_in_cm > reachHandFrom) && ( fighter.Reach_in_cm < reacHandTo)
                        select new { fighter.Fighter_Id, fighter.Name, fighter.Surname, fighter.Age, fighter.Height_in_cm, fighter.Degree, promoution.Promoutions_Name, weight.Name_of_weight_class, fighter.Reach_in_cm};
                
                dataGridView1.DataSource = query.ToList();
                dataGridView1.Columns[0].Visible = false;
              

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Fighters;
        }

        private void addFighterToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Form2 f = new Form2();
             f.Show();
        }


        void deleteChoosenFighter()
        {
            if (MessageBox.Show("Delete this fighter?\n\n", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
             {
                var IdFighterForDelete = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var ChoosenIdFighterForDelete = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                MessageBox.Show(ChoosenIdFighterForDelete);

                var deleteFighterFromDB =
                    from deletes in db.Fighters
                    where deletes.Fighter_Id == IdFighterForDelete
                    select deletes;
               
                

                foreach (var deteil in deleteFighterFromDB )
                {

                    db.Fighters.Remove(deteil);
     
                }

                db.SaveChanges();
                

            }
            else
                {
                    return;
                }  
                    

            }
        

        private void buttonForDelete_Click(object sender, EventArgs e)
        {
            //int index = dataGridView1.CurrentRow.Index;

            deleteChoosenFighter();
        }

        private void ReWrightFighter_Click(object sender, EventArgs e)
        {
            var IdForEditFighter = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Class1.aa = IdForEditFighter;
            Form3 g = new Form3();
            g.Show();
            

        }

        void SaveToExcel()
        {
            // var x = dataGridView1.Rows[0].Cells[0].Value.ToString();
        

        }


        private void saveToExelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.MultiSelect = true;
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);

           
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
            dataGridView1.MultiSelect = false;
         /*   saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Exel File";
            saveFileDialog1.FileName = "";
            if(saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExecelApp = new Microsoft.Office.Interop.Excel.Application();
                ExecelApp.Application.Workbooks.Add(Type.Missing);
                ExecelApp.Columns.ColumnWidth = 20; //меняю ширину ячеек таблицы

                

                for(int i = 0; i <= dataGridView1.Columns.Count; i++)
                {

                    for(int z = 0; z< dataGridView1.Rows.Count; z++)
                    {
                        ExecelApp.Cells[i, z] = "kakaka";
                       // ExecelApp.Cells[i,z] = dataGridView1.Rows[z].Cells[i];

                    }
                }
            }
           
    */

            SaveToExcel();
        }

       
    }
}

