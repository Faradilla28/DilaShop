﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DilaShop.Model
{
    class KeranjangBelanja
    {
        List<Item> itemkeranjangBelanja;
        public List<Diskon> diskonDipakai;
        Payment Payment;
        onKeranjangBelanjaChangedListener onKeranjangBelanjaChangedListener;

        public KeranjangBelanja(Payment payment, onKeranjangBelanjaChangedListener)
        {
            this.payment = payment;
            this.onKeranjangBelanjaChangedListener = onKeranjangBelanjaChangedListener;
            this.itemkeranjangBelanja = new List<Item>();
            this.diskonDipakai = new List<Diskon>();
        }

        internal void addItem(Item item)
        {
            throw new NotImplementedException();
        }

        public List<Item> getItems()
        {
            return this.itemkeranjangBelanja;
        }
        public List<Diskon> getDiskon()
        {
            return this.diskonDipakai;
        }
        public void addDiskon(Diskon diskon)
        {
            this.diskonDipakai.Clear();
            this.diskonDipakai.Add(diskon);
            this.onKeranjangBelanjaChangedListener.addPromoSucceed();
            calculateSubTotal();
        }

        private void removeItem(Item item)
        {
            this.itemkeranjangBelanja.Remove(item);
            this.onKeranjangBelanjaChangedListener.removeItemSucceed();
            calculateSubTotal();
        }

        private void calculateSubTotal()
        {
            double subTotal = 0;
            double promo = 0;
            foreach (Item item in itemkeranjangBelanja)
            {
                subTotal += item.price;

            }
            foreach (Diskon diskon in diskonDipakai)
            {
                if (diskon.potongan == 10000)
                {
                    promo = 10000;
                }
                else if (diskon.potongan == 30000)
                {

                    promo = (subTotal * 30 / 100);

                    if (promo > 30000)
                    {
                        promo = 30000;
                    }
                    else
                    {
                        promo = (subTotal * 30 / 100);
                    }

                }
                else if (diskon.potongan == 25000)
                {
                    promo = (subTotal * 25 / 100);

                }

            }

            payment.updateTotal(subTotal, promo);
        }
    }

    interface onKeranjangBelanjaChangedListener
    {
        void removeItemSucceed();
        void addItemSucceed();
        void addPromoSucceed();
        void OnMenuSelected(Item item);
    }
}
    

