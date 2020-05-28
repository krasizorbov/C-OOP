﻿namespace CollectionHierarchy
{
    public class AddCollection : Collection
    {
        public AddCollection()
            : base()
        { }

        public override int Add(string element)
        {
            this.List.Add(element);

            return this.List.Count - 1;
        }
    }
}
