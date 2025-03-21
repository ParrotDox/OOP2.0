﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionLibrary
{
    public class Point<TKey, TVal>
    {
        TKey key;
        TVal value;

        Point<TKey, TVal> next;

        public TKey Key 
        {
            get { return key; }
        }

        public TVal Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public Point<TKey, TVal> Next
        {
            get { return next; }
            set { next = value; }
        }

        public Point(TKey key, TVal val, int size = 1) 
        {
            value = val;
            this.key = key;
            next = null;
        }

        public Point(TKey key)
        {
            //value = default(T);
            this.key = key;
            next = null;
        }

        public Point() 
        {
            value = default(TVal);
            next = null;
            key = default(TKey);
        }

        public Point(Point<TKey, TVal> point) 
        {
            this.key = point.Key;
            this.value = point.Value;
            if (point.Next == null)
                this.next = null;
            else
                this.next = new Point<TKey, TVal>(point.Next.Key, point.Next.Value);
        }

        public override string ToString()
        {
            if (value == null) 
            {
                return (key).ToString() + " : " + "пусто";
            }
            return (key).ToString() + " : " + value.ToString();
        }

        public override bool Equals(Object obj)
        {
            if (obj is Point<TKey, TVal> point)
                return ((Equals(Key, point.Key)) & (Equals(Value, point.Value)) & (Equals(Next, point.Next)));
            return false;
        }
    }
}
