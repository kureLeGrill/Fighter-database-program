using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{ 
    public partial class Form3 : Form
    {

        Fighters_DatabaseEntities db = new Fighters_DatabaseEntities();

        public Form3()      
        {
            InitializeComponent();
            var IdForEditFighter = Convert.ToInt32(Class1.aa);
            // MessageBox.Show(IdForEditFighter);
                var  queryForComboBoxPromoution = from promoution in db.Promoutions
                                                    select promoution.Promoutions_Name;

            var queryForComboBoxdWeight = from weight in db.Weight_Classes
                                          select weight.Name_of_weight_class;

            var ListForDataCombBoxForWeight = queryForComboBoxdWeight.ToList();
            var ListForDataComboBoxForPromoution = queryForComboBoxPromoution.ToList();

            ComboBoxForEditPromoution.DataSource = ListForDataComboBoxForPromoution;
            ComboBoxForEditWeight.DataSource = ListForDataCombBoxForWeight;


            var queryForDeleteFighter = from fighter in db.Fighters
                                         join promoution in db.Promoutions on fighter.Promoution_Id equals promoution.Promoutions_Id
                                         join weight in db.Weight_Classes on fighter.Weight_Id equals weight.Weight_Id
                                         where IdForEditFighter == fighter.Fighter_Id
                                       select new { fighter.Fighter_Id, fighter.Name, fighter.Surname,
                                           fighter.Age, fighter.Height_in_cm,
                                           fighter.Degree, promoution.Promoutions_Name,
                                           weight.Name_of_weight_class, fighter.Reach_in_cm };

            foreach(var v in queryForDeleteFighter)
            {
                TextBoxForEditName.Text = v.Name;
                TextBoxForEditSurname.Text = v.Surname;
                TextBoxForEditAge.Text = Convert.ToString(v.Age);
                TextBoxForEditHeight.Text = Convert.ToString(v.Height_in_cm);
                ComboBoxForEditPromoution.Text = v.Promoutions_Name;
                ComboBoxForEditWeight.Text = v.Name_of_weight_class;
                TextBoxForEditReach.Text = Convert.ToString(v.Reach_in_cm);
                TextBoxForEditDegree.Text = v.Degree;
    

            }

         

        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void buttonForEdit_Click(object sender, EventArgs e)
        {
            var IdForEditFighter = Convert.ToInt32(Class1.aa);

            var name = TextBoxForEditName.Text;
            var surname = TextBoxForEditSurname.Text;
            var weightIn = Convert.ToString(ComboBoxForEditWeight.Text);
            var height = Convert.ToInt32(TextBoxForEditHeight.Text);
            var age = Convert.ToInt32(TextBoxForEditAge.Text);
            var reach = Convert.ToInt32(TextBoxForEditReach.Text);
            var promoution = Convert.ToString(ComboBoxForEditPromoution.Text);
            var degree = TextBoxForEditDegree.Text;

            var promoutionNameFromBox = ComboBoxForEditPromoution.Text;
            var weightCategoryNameBox = ComboBoxForEditWeight.Text;


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




            var queryForCurentFighter = from fighter in db.Fighters
                                        where fighter.Fighter_Id == IdForEditFighter
                                        select fighter;

            foreach (var j in queryForCurentFighter)
                {
                j.Name = name;
                j.Surname = surname;
                j.Promoution_Id = promoution_idd;
                j.Height_in_cm = height;
                j.Reach_in_cm = reach;
                j.Weight_Id = weight_id;
                j.Degree = degree;
                j.Age = age;
                }
            db.SaveChanges();
           

        }
    }
}
