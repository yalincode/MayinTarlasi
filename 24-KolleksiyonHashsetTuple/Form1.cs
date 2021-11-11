using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_KolleksiyonHashsetTuple
{
    public partial class Form1 : Form
    {
        HashSet<int> hashSet = new HashSet<int>();//Bool sonuç verir

        //Kümeler gibi düşünebiliriz tüm kolleksiyonları.
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtVeri.Text);
            bool result=hashSet.Add(sayi); //İçerde tuttuğu datayı yeniden ekleyemezsin. Ayrıca bize bool bir cevap döner eğer sayıyı ekleyebilirse. Daha performanslı çalışır. HashingSerching algoritim. Eklediğiniz bir şey herhangi bir indexte olabilir.
            if (result==true)
            {
                MessageBox.Show("Ekleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Ekleme işlemi başarısız");
            }


        }

        public void RefreshListBox()
        {
            //for (int i = 0; i < hashSet.Count; i++)
            //{
            //    int sayi=hashSet[i]; İndexer yapısı yok
            //}

            listBox1.Items.Clear();
            foreach (var item in hashSet)
            {
                listBox1.Items.Add(item);
            }
            //Elmanlara erişirken foreach ile alabiliriz.
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtVeri.Text);
            if (hashSet.Remove(sayi))
            {
                MessageBox.Show("Silme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız");
            }
            RefreshListBox();
            
        }

        private void btnRemoveWhere_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(txtVeri.Text);
            //lambda expression
            //hashSet.RemoveWhere((int i) => { return i < 10; });//Silme işlemi izin verilip verilmediği koşulu.

            hashSet.RemoveWhere(CollectionRemovePredicate);//Metot içinde metot ile parametre. Result i küçüse 10 dan true döner ve silme işlemi gerçekleştirir. Where şart belirtir.
            
        }
       bool CollectionRemovePredicate(int i)
        {
            bool result = i < 10;
            return result;
        }

        private void btnUnionWith_Click(object sender, EventArgs e)
        {
            //Birleştirme=> Union A VE B kümesi birleşimi gibi düşün.

            
            HashSet<string> hashset1 = new HashSet<string>();
            hashset1.Add("C#");
            hashset1.Add("PHP");
            hashset1.Add("Java");
            hashset1.Add("Ruby");
            hashset1.Add("Delphi");

            HashSet<string> hashset2 = new HashSet<string>();
            hashset2.Add("PHP");
            hashset2.Add("Javascript");
            hashset2.Add("HTML");
            hashset2.Add("Ruby");
            hashset2.Add("Go");

            hashset1.UnionWith(hashset2);//İki kolleksiyonu alır ve birleştirir fakat farklı olanlarını alır aynı itemları almaz.
            foreach (var item in hashset1)
            {
                listBox1.Items.Add(item);
            }

            //Kolleksiyon sort edilemez. Birleştiklerindeki sırada farklı olabilir. Ama bu metot önemlidir.
        }

        private void btnIntersectWith_Click(object sender, EventArgs e)
        {
            //Intersect With => iki kolleksiyon arası aynı olan elemanları alır yani kesişimi verir.

            HashSet<string> hashset1 = new HashSet<string>();
            hashset1.Add("C#");
            hashset1.Add("PHP");
            hashset1.Add("Java");
            hashset1.Add("Ruby");
            hashset1.Add("Delphi");

            HashSet<string> hashset2 = new HashSet<string>();
            hashset2.Add("PHP");
            hashset2.Add("Javascript");
            hashset2.Add("HTML");
            hashset2.Add("Ruby");
            hashset2.Add("Go");

            hashset1.IntersectWith(hashset2);
            foreach (var item in hashset1)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnExceptWith_Click(object sender, EventArgs e)
        {
           //İki kolleksiyon arası farkı almak için kullanılan bir metottur.

            HashSet<string> hashset1 = new HashSet<string>();
            hashset1.Add("C#");
            hashset1.Add("PHP");
            hashset1.Add("Java");
            hashset1.Add("Ruby");
            hashset1.Add("Delphi");

            HashSet<string> hashset2 = new HashSet<string>();
            hashset2.Add("PHP");
            hashset2.Add("Javascript");
            hashset2.Add("HTML");
            hashset2.Add("Ruby");
            hashset2.Add("Go");

            hashset1.ExceptWith(hashset2);

            foreach (var item in hashset1)
            {
                listBox1.Items.Add(item);
            }

           
        }
    }
}
