using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5C_
{
    internal class Store
    {
        private string storeName;
        private string address;
        private string profileDescription;
        private string contactPhone;
        private string email;
        private double area;

        public string StoreName
        {
            get { return storeName; }
            set { storeName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string ProfileDescription
        {
            get { return profileDescription; }
            set { profileDescription = value; }
        }

        public string ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public double Area
        {
            get { return area; }
            set { area = value; }
        }

        public Store(string storeName, string address, string profileDescription, string contactPhone, string email, double area)
        {
            this.storeName = storeName;
            this.address = address;
            this.profileDescription = profileDescription;
            this.contactPhone = contactPhone;
            this.email = email;
            this.area = area;
        }

        public void EnterStoreData()
        {
            Console.WriteLine("Enter store name:");
            storeName = Console.ReadLine();

            Console.WriteLine("Enter store address:");
            address = Console.ReadLine();

            Console.WriteLine("Enter store profile description:");
            profileDescription = Console.ReadLine();

            Console.WriteLine("Enter contact phone:");
            contactPhone = Console.ReadLine();

            Console.WriteLine("Enter email:");
            email = Console.ReadLine();

            Console.WriteLine("Enter store area (in square meters):");
            area = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayStoreData()
        {
            Console.WriteLine($"Store Name: {storeName}");
            Console.WriteLine($"Address: {address}");
            Console.WriteLine($"Profile Description: {profileDescription}");
            Console.WriteLine($"Contact Phone: {contactPhone}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Area: {area} m²");
        }

        public static Store operator +(Store store, double areaIncrease)
        {
            store.area += areaIncrease;
            return store;
        }

        public static Store operator -(Store store, double areaDecrease)
        {
            store.area -= areaDecrease;
            return store;
        }

        public static bool operator ==(Store store1, Store store2)
        {
            return store1.area == store2.area;
        }

        public static bool operator !=(Store store1, Store store2)
        {
            return store1.area != store2.area;
        }

        public static bool operator <(Store store1, Store store2)
        {
            return store1.area < store2.area;
        }

        public static bool operator >(Store store1, Store store2)
        {
            return store1.area > store2.area;
        }

        public override bool Equals(object obj)
        {
            if (obj is Store otherStore)
            {
                return this.area == otherStore.area;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return area.GetHashCode();
        }
    }
}
