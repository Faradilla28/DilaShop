using DilaShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilaShop.Controller
{
    class MainWindowController
    {
        KeranjangBelanja keranjangBelanja;

        public MainWindowController(KeranjangBelanja keranjangBelanja, Payment payment)
        {
            this.keranjangBelanja = keranjangBelanja;
        }
        public void addItem(Item item)
        {
            this.keranjangBelanja.addItem(item);
        }
        private void removeItem(Item item)
        {
            this.keranjangBelanja.removeItem(item);
        }
        public List<Item> getItems()
        {
            return this.keranjangBelanja.getItems();
        }
        public void addDiskon(Diskon diskon)
        {

            this.keranjangBelanja.addDiskon(diskon);
        }
        public List<Diskon> getDiskon()
        {
            return this.keranjangBelanja.getDiskon();
        }
    }
}
