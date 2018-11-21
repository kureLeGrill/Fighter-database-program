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

    public partial class Form2 : Form
    {
        Fighters_DatabaseEntities db = new Fighters_DatabaseEntities();

        


        public Form2()
        {
            InitializeComponent();
            var queryForCombobox = from promoution in db.Promoutions
                                   //group promoution by promoution.Promoutions_Name into gg
                                   select promoution.Promoutions_Name;
                                   /*from fighter in db.Fighters
                                   join promoution in db.Promoutions on fighter.Promoution_Id equals promoution.Promoutions_Id
                                   join weight in db.Weight_Classes on fighter.Weight_Id equals weight.Weight_Id
                                   group promoution by promoution.Promoutions_Name into g
                                   orderby g.Key
                                   select g;*/
                                  // select promoution.Promoutions_Name;

            var listFromQuery = queryForCombobox.ToList();
            comboBoxForPromoution.DataSource = listFromQuery;
            // listFromQuery.ElementAt(3);



            var queryForWeight = from weight in db.Weight_Classes
                                 select weight.Name_of_weight_class;

            var listFromqueryForWeight = queryForWeight.ToList();
            comboBoxForWeight.DataSource = listFromqueryForWeight;


        }

        private void AddFighter_Click(object sender, EventArgs e)
        {
            int nuzl;
            string name;// = string.IsNullOrEmpty(text_box_for_add_name.Text)? text_box_for_add_name.Text :  ;
            string surname;// = text_box_for_add_surname.Text;
            var weightIn = comboBoxForWeight.Text;
            int height;//= int.TryParse(text_box_for_add_height.Text, out nuzl)? : ;
            int age;// = Convert.ToInt32(text_box_for_add_age.Text);
            int reach;// = Convert.ToInt32(text_box_for_add_reach.Text);
            string degree;// = Convert.ToString(text_box_for_add_degree.Text);
            var promoution = comboBoxForPromoution.Text;

            if (string.IsNullOrEmpty(text_box_for_add_name.Text))
            {
                MessageBox.Show("You forgot input name of fighter.");
                return;
            }
            else
            {
                name = text_box_for_add_name.Text;
            }

            if (string.IsNullOrEmpty(text_box_for_add_surname.Text))
            {
                MessageBox.Show("You forgot input surname of fighter.");
                return;
            }
            else
            {
                surname = text_box_for_add_surname.Text;
            }

            if (string.IsNullOrEmpty(text_box_for_add_degree.Text))
            {
                MessageBox.Show("You forgot input degree of fighter.");
                return;
            }
            else
            {
                degree = text_box_for_add_name.Text;
            }



            if (int.TryParse(text_box_for_add_height.Text, out nuzl))
            {
                height = nuzl;
                if (int.TryParse(text_box_for_add_age.Text, out nuzl))
                {
                    age = nuzl;
                    if(int.TryParse(text_box_for_add_reach.Text, out nuzl))
                    {
                        reach = nuzl;
                    }
                    else
                    {
                        MessageBox.Show("Put numbers, not letters or nothing, into the text box for reach.\n");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Put numbers, not letters or nothing, into the text box for age.\n");
                    return;
                }
                        
            }
            else
            {
                MessageBox.Show("Put numbers, not letters or nothing, into the text box for height.\n");
                return;
            };
            

            int promoution_idd = 0;
            switch(promoution)
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
            switch (weightIn)
            {
                case "FLYWEIGHT":
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


            var MaxFghterIdFromTableFighters =  // делаю запрос pomoci linq
               (from prod in db.Fighters
                select prod.Fighter_Id)
                       .Max();

           int bjj =  Convert.ToInt32(MaxFghterIdFromTableFighters); // нужно делать преобразования типов?? или это просто convert ??!?!?!??? \0_о/ || /о_0\

   

            var Fighter = new Fighters { Name = name, Surname = surname, Age = age, Degree = degree, Fighter_Id = bjj + 1, Height_in_cm = height, Promoution_Id = promoution_idd, Reach_in_cm = reach, Weight_Id = weight_id
                                                        };
            db.Fighters.Add(Fighter);
            db.SaveChanges();
           // db.Fighters.Add();

        }

       
    }
}
