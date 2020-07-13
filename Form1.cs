using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private StoreItem items = new StoreItem();
        private DataTable Cart = new DataTable();
        private DataGridViewRow currentRow;
        private bool discountApplied = false;
        private float discountRate = 5; //The %age of price deduction to be applied to the grand total
        private float taxRate = 13; //GST as a percentage of the cart total, factored into the grand total

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Populate the grid with all store items
            DataTable dt = items.Select_All();
            Main_screen.DataSource = null;
            Main_screen.DataSource = dt;
            messageBox.Text = "Showing all items";

            //Initializing the quantity of items in the cart to 0
            Qty_1item.Text = 0.ToString();
            Qty_to_add_or_remove.Value = 1;

            //Setting the current row to the first row in the data grid
            this.currentRow = Main_screen.Rows[0];

            //Preparing the cart grid view (same format as all items' grid view)
            foreach (DataGridViewColumn col in Main_screen.Columns)
            {
                if (col.Name.ToString().ToLower() == "QUANTITY".ToLower())
                {
                    this.Cart.Columns.Add("In Cart");
                }
                else
                {
                    this.Cart.Columns.Add(col.Name);
                }
                
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Heading_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Items_view_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = items.Select_All();
            Main_screen.DataSource = null;
            Main_screen.DataSource = dt;
            messageBox.Text = "Showing all items";
            this.currentRow = Main_screen.Rows[0];
        }

        private void Item_add_btn_Click(object sender, EventArgs e)
        {
            int quantityToAdd = 1;
            //string qty_string = Qty_to_add.Text;
            quantityToAdd = (int) Qty_to_add_or_remove.Value;
            //bool result = int.TryParse(qty_string, out quantityToAdd);
            DataTable dt = items.SelectOneBySKU(int.Parse(this.currentRow.Cells[0].Value.ToString()), quantityToAdd);

            Console.WriteLine(dt.Rows[0]["Description"] + " +> " + dt.Rows[0]["Quantity"]);
            if (/*!result ||*/ quantityToAdd < 0)
            {
                MessageBox.Show("Please enter a valid quantity to add!");
            }
            else if (this.currentRow.Cells[0].Value != null)//Making sure that SKU for the item to add is not empty
            {
                DataRow existingCartItem = fetch_from_cart(int.Parse(this.currentRow.Cells[0].Value.ToString()));

                if (existingCartItem != null)
                {
                    int existingQuantity = int.Parse(existingCartItem["In Cart"].ToString());
                    int newQuantity = existingQuantity + quantityToAdd;
                    existingCartItem["In Cart"] = newQuantity;
                    updateInterfaceAfterItemAddedOrRemoved(existingCartItem, quantityToAdd);
                }
                else
                {           
                    DataRow newRow = this.Cart.NewRow();
                    int i = 0;

                    foreach (DataColumn col in this.Cart.Columns)
                    {
                        newRow[col.ColumnName] = this.currentRow.Cells[i].Value;
                        i++;
                    }
                    newRow["In Cart"] = quantityToAdd;


                    if (this.Cart != null)
                    {
                        this.Cart.Rows.Add(newRow);
                    }

                    updateInterfaceAfterItemAddedOrRemoved(newRow, quantityToAdd);
                }
            }
            else
            {
                MessageBox.Show("Invalid or no item selected to add!");
            }
            
        }

        private void Main_screen_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.currentRow = Main_screen.Rows[e.RowIndex];
            updateInterfaceAfterRowChanged();

        }

        private void Cart_view_btn_Click(object sender, EventArgs e)
        {
            Main_screen.DataSource = null;
            Main_screen.DataSource = this.Cart;
            this.currentRow = Main_screen.Rows[0];
            
            if (this.Cart.Rows.Count == 0) //The messageBox is a custom message Box I've added, not the standard C# MessageBox
            {
                messageBox.Text = "Your cart is currently empty";
            }
            else
            {
                messageBox.Text = "Showing all items from your cart";
            }
            
        }

        private void Main_screen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.currentRow = Main_screen.Rows[e.RowIndex];
            updateInterfaceAfterRowChanged();

        }

        private DataRow fetch_from_cart(int sku)
        {
            foreach (DataRow itemRow in this.Cart.Rows)
            {
                if (itemRow["SKU"].ToString() == sku.ToString())
                    return itemRow;
            }

            return null;
        }

        private void updateInterfaceAfterItemAddedOrRemoved(DataRow addedItem, int newlyAdded)
        {
            //Update Quantity in cart for the current item
            Qty_1item.Text = addedItem["In Cart"].ToString();
            
            //Display the correct message in the messageBox
            if (addedItem != null)
                messageBox.Text = newlyAdded.ToString() + " " + addedItem["Description"] + "(s) added to your cart";

            //Iterate through all the rows in the cart and add prices * quantities in the cart
            float cartTotal = 0;

            foreach (DataRow itemRow in this.Cart.Rows)
            {
                int itemQuantity = int.Parse(itemRow["In Cart"].ToString());
                float itemPrice = float.Parse(itemRow["Price"].ToString());

                cartTotal += (itemQuantity * itemPrice);
            }
            //Update the cart total
            CartTotal.Text = String.Format("{0:0.00}", cartTotal); ;

            //Calculate the grand total in a different function
            float grandTotal = calculateGrandTotal(cartTotal);

            //Update the grand Total
            GrandTotal.Text = String.Format("{0:0.00}", grandTotal);
        }

        private void updateInterfaceAfterRowChanged()
        {
            int current_sku = Int32.Parse(this.currentRow.Cells[0].Value.ToString());
            int quantityAdded = 0;

            DataRow currentItem = fetch_from_cart(current_sku);

            if (currentItem != null)
                quantityAdded = Int32.Parse(currentItem["In Cart"].ToString());

            Qty_1item.Text = quantityAdded.ToString();
            Qty_to_add_or_remove.Value = 1;
        }

        private float calculateGrandTotal(float cartTotal)
        {
            float totalWithGST = cartTotal * (1 + this.taxRate / 100);

            if (this.discountApplied == true)
            {
                return  totalWithGST * (1 - this.discountRate / 100);
            }

            return totalWithGST;
        }

        private void Item_removefromcart_Click(object sender, EventArgs e)
        {
            messageBox.Text = "Removing something!";
            int quantityToRemove = 1;
            quantityToRemove = (int) Qty_to_add_or_remove.Value;

            if (/*!result ||*/ quantityToRemove < 0)
            {
                MessageBox.Show("Please enter a valid quantity to remove!");
            }
            else if (this.currentRow.Cells[0].Value != null)
            {
                DataRow existingCartItem = fetch_from_cart(int.Parse(this.currentRow.Cells[0].Value.ToString()));

                int existingQuantity = int.Parse(existingCartItem["In Cart"].ToString());

                if (existingQuantity <= 0)
                {
                    MessageBox.Show("This item is not present in the cart!");
                }
                int newQuantity = existingQuantity + quantityToRemove;
                existingCartItem["In Cart"] = newQuantity;
                updateInterfaceAfterItemAddedOrRemoved(existingCartItem, quantityToRemove);

            }
        }

        private void Qty_to_add_or_remove_ValueChanged(object sender, EventArgs e)
        {

        }

        /*private void Categories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/
    }
}
