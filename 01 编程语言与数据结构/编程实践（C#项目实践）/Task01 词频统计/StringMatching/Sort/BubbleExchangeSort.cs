﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StringMatching
{
    public class BubbleExchangeSort : SortStrategy
    {
        public override void Sort<T>(List<T> nodes)
        {
            for (int i = 0; i < nodes.Count - 1; i++)
            {
                for (int j = nodes.Count - 1; j > i; j--)
                {
                    if (nodes[j].CompareTo(nodes[j - 1]) <0)
                    {
                        T temp = nodes[j - 1];
                        nodes[j - 1] = nodes[j];
                        nodes[j] = temp;
                    }
                }
            }
        }
    }
}
