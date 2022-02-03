using System;

namespace NMovies.Models
{
    public class QueryParameters
    {
        const int _maxSize = 50;
        private int _size = 5;

        public int Page { get; set; }
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = Math.Min(_maxSize, value);
            }
        }

        public string SortBy { get; set; } = "Title";


        private string _sortOrder = "asc";
        public string SortOrder
        {
            get
            {
                return _sortOrder;
            }
            set
            {
                if (value == "asc" || value == "desc")
                {
                    _sortOrder = value;
                }
            }
        }
    }
}
