// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ISwap.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2015 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Sort
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// Object swapper interface
    /// </summary>
    public interface ISwap
    {
        #region Methods
        void Swap(IList array, int left, int right);
        void Set(IList array, int left, int right);
        void Set(IList array, int left, object obj);
        #endregion
    }

    public interface ISwap<T>
    {
        #region Methods
        void Swap(IList<T> array, int left, int right);
        void Set(IList<T> array, int left, int right);
        void Set(IList<T> array, int left, T obj);
        #endregion
    }
}