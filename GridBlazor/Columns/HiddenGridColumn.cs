using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GridBlazor.Columns
{
    public class HiddenGridColumn<T, TDataType> : GridColumn<T, TDataType>
    {
        public HiddenGridColumn(Expression<Func<T, TDataType>> expression, CGrid<T> grid) : this(expression, null, grid)
        {
        }

        public HiddenGridColumn(Expression<Func<T, TDataType>> expression, IComparer<TDataType> comparer, CGrid<T> grid)
           : base(expression, comparer, grid)
        {
            Hidden = true;
        }
    }
}
