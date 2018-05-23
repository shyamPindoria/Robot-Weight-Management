using System;
using System.Collections.Generic;

namespace FirstFRCParts
{
    [Serializable()]
    class Robot
    {

        private List<Part> parts;
        private List<Part> catalogue;
        private List<string> categories;
        private List<string> suppliers;
        public double targetWeight { get; set; }
        public double targetCost { get; set; }

        /// <summary>
        /// Default constructor initialize the arrays
        /// </summary>
        public Robot()
        {
            this.parts = new List<Part>();
            this.catalogue = new List<Part>();
            this.categories = new List<string>();
            this.suppliers = new List<string>();
        }

        /// <summary>
        /// Add a part to the catalogue
        /// </summary>
        /// <param name="part">The part to add</param>
        public void addToCatalogue(Part part)
        {
            Boolean found = false;
            //Loop through the catalogue array to check whether the part already exists
            for (int i = 0; !found && i < this.catalogue.Count; i++)
            {
                if (part.Name == this.catalogue[i].Name && part.Supplier == this.catalogue[i].Supplier)
                {
                    found = true;
                }
            }
            //If the part is not found
            if (!found)
            {
                //Add the part to the catalogue
                this.catalogue.Add(part);
            }
        }

        /// <summary>
        /// Add a category to the categories list
        /// </summary>
        /// <param name="category">Category to add</param>
        public void addCategory(string category)
        {
            //Checking if a category already exists
            bool found = false;
            for (int i = 0; i < this.categories.Count && !found; i++)
            {
                //Compare the category with categories form the array
                if (this.categories[i] == category)
                {
                    found = true;
                }
            }
            //Add the category to the category array in robot if it is no present
            if (!found)
            {
                categories.Add(category);
            }
            
        }

        /// <summary>
        /// Add a supplier to the suppliers list
        /// </summary>
        /// <param name="supplier">Supplier to add</param>
        public void addSupplier(string supplier)
        {
            //Checking if a supplier already exists
            bool found = false;
            for (int i = 0; i < this.suppliers.Count && !found; i++)
            {
                //Compare the supplier with suppliers form the array
                if (this.suppliers[i] == supplier)
                {
                    found = true;
                }
            }
            //Add the supplier to the supplier array in robot if it is no present
            if (!found)
            {
                suppliers.Add(supplier);
            }
            
        }

        /// <summary>
        /// Remove a part from the parts array
        /// </summary>
        /// <param name="index">Index of the part to remove</param>
        public void removePart(int index)
        {
            parts.RemoveAt(index);
        }

        /// <summary>
        /// This method checks whether a part already exists at the specified index in parts arraylist
        /// if there is a part at the specified index, then remove it and add an new part
        /// if there is no part at that index, add a new part
        /// </summary>
        /// <param name="index">Index in parts arraylist</param>
        /// <param name="p">Part to add to the arraylist</param>
        public void insertPart(int index, Part p)
        {
            //If index is less than the part count
            if (index < parts.Count)
            {
                //Remove the existing part
                parts.RemoveAt(index);
            }
            //Add the new part
            parts.Insert(index, p);

        }

        /// <summary>
        /// Checks if a part exists in the parts list
        /// </summary>
        /// <param name="part">Part to check</param>
        /// <returns>Index of the part. -1 if the part does not exist</returns>
        public int containsPart(Part part)
        {
            //Loop through each part in the array
            for (int i = 0; i < this.parts.Count; i++)
            {
                //Check if the part exists
                if (parts[i].Equals(part))
                {
                    //Return the index of the part
                    return i;
                }
            }
            //If part does not exist
            return -1;
        }

        /// <summary>
        /// Calculates the total weight of the entire robot
        /// </summary>
        /// <returns>Total weight of the robot</returns>
        public double TotalWeight()
        {
            double weight = 0;
            //Loop through each part
            foreach (Part p in parts)
            {
                //Sum up the total weight of each part
                weight += p.TotalWeight;
            }

            return weight;
        }

        /// <summary>
        /// Calculate the total cost of the entire robot
        /// </summary>
        /// <returns>The total cost of the robot</returns>
        public double TotalCost()
        {
            double cost = 0;
            //Loop through each part
            foreach (Part p in parts)
            {
                //Sum up the total costs
                cost += p.TotalCost;
            }

            return cost;
        }

        /// <summary>
        /// Return a part at a specified index
        /// </summary>
        /// <param name="index">Index of the part</param>
        /// <returns>Part at the specified index</returns>
        public Part getPart(int index)
        {
            return this.parts[index];
        }

        /// <summary>
        /// Get the part at a specified index from the catalogue
        /// </summary>
        /// <param name="index">Index of the part</param>
        /// <returns>Part at the specified index</returns>
        public Part getCataloguePart(int index)
        {
            return this.catalogue[index];
        }
        
        /// <summary>
        /// Returns the category at the specified index
        /// </summary>
        /// <param name="index">Index of the category</param>
        /// <returns>The category at the specified index</returns>
        public string getCategory(int index)
        {
            return this.categories[index];
        }

        /// <summary>
        /// Returns the supplier at the specified index
        /// </summary>
        /// <param name="index">Index of the supplier</param>
        /// <returns>The supplier at the specified index</returns>
        public string getSupplier(int index)
        {
            return this.suppliers[index];
        }

        /// <summary>
        /// Get the number of categories
        /// </summary>
        /// <returns>Count of the categories array</returns>
        public int categoriesCount()
        {
            return this.categories.Count;
        }

        /// <summary>
        /// Get the number of the suppliers
        /// </summary>
        /// <returns>Count of the suppliers array</returns>
        public int suppliersCount()
        {
            return this.suppliers.Count;
        }

        /// <summary>
        /// Get the number of parts in the catalogue
        /// </summary>
        /// <returns>Count of the catalogue array</returns>
        public int catalogueCount()
        {
            return this.catalogue.Count;
        }

        /// <summary>
        /// Get the number of parts in the parts array
        /// </summary>
        /// <returns>Count of parts in the parts array</returns>
        public int partsCount()
        {
            return this.parts.Count;
        }

        /// <summary>
        /// Insertion sort algorithm to Sort the parts in the parts array 
        /// according to the type and the order
        /// </summary>
        /// <param name="type">Attribute on which to sort the parts</param>
        /// <param name="order">Ascending or Descending</param>
        public void sortBy(string type, string order)
        {   
            //Index of the parts that will be compared
            int inner, outer;
            //Loop through the parts
            for (outer = 1; outer < parts.Count; outer++)
            {
                //The index part to compare with
                inner = outer;

                //If sorting by name
                if (type.Equals("Name"))
                {
                    //Compare the names of the parts
                    while (inner > 0 && parts[inner - 1].Name.CompareTo(parts[inner].Name) >= 0)
                    {
                        //Switch the parts
                        Part temp = parts[inner]; //Store the current part in a temp variable
                        parts[inner] = parts[inner - 1]; //Replace the current part with the one before
                        parts[inner - 1] = temp; //Replace the part before with temp
                        inner--;
                    }
                }
                //If sorting by category
                else if (type.Equals("Category"))
                {
                    //Compare the categories of the parts
                    while (inner > 0 && parts[inner - 1].Category.CompareTo(parts[inner].Category) >= 0)
                    {
                        //Switch the parts
                        Part temp = parts[inner];
                        parts[inner] = parts[inner - 1];
                        parts[inner - 1] = temp;
                        inner--;
                    }
                }
                //If sorting by supplier
                else if (type.Equals("Supplier"))
                {
                    //Compare the suppliers of the parts
                    while (inner > 0 && parts[inner - 1].Supplier.CompareTo(parts[inner].Supplier) >= 0)
                    {
                        //Switch the parts
                        Part temp = parts[inner];
                        parts[inner] = parts[inner - 1];
                        parts[inner - 1] = temp;
                        inner--;
                    }
                }
                //If sorting by unit cost
                else if (type.Equals("Unit Cost"))
                {
                    //Compare the unit costs of the part
                    while (inner > 0 && parts[inner - 1].UnitCost.CompareTo(parts[inner].UnitCost) >= 0)
                    {
                        Part temp = parts[inner];
                        parts[inner] = parts[inner - 1];
                        parts[inner - 1] = temp;
                        inner--;
                    }
                }
                //If sorting by unit weight
                else if (type.Equals("Unit Weight"))
                {
                    //Compare the unit weights of the parts
                    while (inner > 0 && parts[inner - 1].UnitWeight.CompareTo(parts[inner].UnitWeight) >= 0)
                    {
                        //Switch the parts
                        Part temp = parts[inner];
                        parts[inner] = parts[inner - 1];
                        parts[inner - 1] = temp;
                        inner--;
                    }
                }
                //If sorting by number
                else if (type.Equals("Number"))
                { 
                    //Compare the quantities of the parts
                    while (inner > 0 && parts[inner - 1].Number.CompareTo(parts[inner].Number) >= 0)
                    {
                        //Switch the parts
                        Part temp = parts[inner];
                        parts[inner] = parts[inner - 1];
                        parts[inner - 1] = temp;
                        inner--;
                    }
                }
            }

            //If sorting in descending order
            if (order.Equals("Descending"))
            {
                //Reverse the array
                parts.Reverse();
            }
        }

    }
}
