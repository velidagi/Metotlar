using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //ctor +tabtab  (constructor)
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            // items e yeni eleman satırı eklemeden önce eski elemanları saklamak lazım
            // tempArray de önceki bilgileri saklar/yedekler.
            T[] tempArray = items;
            
            // items daki eleman sayısını dinamik şekilde mevcuttan 1 arttırır.
            // .Length = mevcut eleman sayısı.
            items = new T[items.Length + 1];
            
            // For içerisinde tempArray deki elemanları  teker teker yeni items e eklettik.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            // items.length -1 demek son elemana eşittir. (5 elemanlı dizinin son elemanı 4 dür.)
            items[items.Length - 1] = item;

        }
    }
}
