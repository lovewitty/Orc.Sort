// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShellSort.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2015 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Sort.NSort
{
    using System.Collections;

    public class ShellSort : SwapSorter
    {
        #region Constructors
        public ShellSort() : base()
        {
        }

        public ShellSort(IComparer comparer, ISwap swapper)
            : base(comparer, swapper)
        {
        }
        #endregion

        #region Methods
        public override void Sort(IList list)
        {
            int h;
            int i;
            int j;
            object b;
            bool loop = true;

            h = 1;

            while (h*3 + 1 <= list.Count)
            {
                h = 3*h + 1;
            }
            while (h > 0)
            {
                for (i = h - 1; i < list.Count; i++)
                {
                    b = list[i];
                    j = i;
                    loop = true;
                    while (loop)
                    {
                        if (j >= h)
                        {
                            if (this.Comparer.Compare(list[j - h], b) > 0)
                            {
                                this.Swapper.Set(list, j, j - h);
                                j = j - h;
                            }
                            else
                            {
                                loop = false;
                            }
                        }
                        else
                        {
                            loop = false;
                        }
                    }
                    this.Swapper.Set(list, j, b);
                }
                h = h/3;
            }
        }
        #endregion
    }
}