using System.Collections;

namespace _2_
{
	internal class ItemsComparer : IComparer
    {
        private int _colIndex;

        public int ColIndex
        {
            get { return _colIndex; }
            set { _colIndex = value; }
        }

        private SortOrder _sortDir;

        public SortOrder SortDir
        {
            get { return _sortDir; }
            set { _sortDir = value; }
        }

        public ItemsComparer()
        {
            _sortDir = SortOrder.None;
        }

        public int Compare(object x, object y)
        {
            ListViewItem A = (ListViewItem)x;
            ListViewItem B = (ListViewItem)y;

            int result;

            switch (_colIndex)
            {
                case 0:
                    result = string.Compare(A.SubItems[_colIndex].Text, B.SubItems[_colIndex].Text, false);
                    break;
                case 1:
                    double ValueA = double.Parse(A.SubItems[_colIndex].Text);
                    double ValueB = double.Parse(B.SubItems[_colIndex].Text);
                    result = ValueA.CompareTo(ValueB);
                    break;
                case 2:
                    result = string.Compare(A.SubItems[_colIndex].Text, B.SubItems[_colIndex].Text, false);
                    break;
                case 3:
                    result = string.Compare(A.SubItems[_colIndex].Text, B.SubItems[_colIndex].Text, false);
                    break;
                default:
                    result = string.Compare(A.SubItems[_colIndex].Text, B.SubItems[_colIndex].Text, false);
                    break;
            }

            if (_sortDir == SortOrder.Descending)
            {
                return -result;
            }
            else
            {
                return result;
            }
        }
    }
}
