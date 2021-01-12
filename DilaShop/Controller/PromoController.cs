using DilaShop.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DilaShop.Controller
{
    public class PromoController
    {
        public List<Diskon> diskon;

        public PromoController()
        {
            diskon = new List<Diskon>();
        }

        public void addPromo(Diskon diskon)
        {
            this.diskon.Add(diskon);
        }

        public List<Diskon> getDiskon()
        {
            return this.diskon;
        }

        internal void addPromo(Diskon diskon3)
        {
            throw new NotImplementedException();
        }
    }
}
