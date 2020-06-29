using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MainLibrary
{
    public class MainLibrary
    {
    }

    public class Books
    {
        public int BookID { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string PublicationDate { get; set; }
        public int GenreID { get; set; }
        public int PublisherID { get; set; }
        public string Desciption { get; set; }
        public string UpdatedDate { get; set; }

        public Books(int bookID, string name, string authorName, string publicationDate, int genreID, int publisherID, string description/*, string bookCover*/, string updatedDate)
        {
            BookID = bookID;
            Name = name;
            AuthorName = authorName;
            PublicationDate = publicationDate;
            GenreID = genreID;
            PublisherID = publisherID;
            Desciption = description;
            //BookCover = bookCover;
            UpdatedDate = updatedDate;
        }
    }

    public class Publishers
    {
        public int PublisherID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int Postcode { get; set; }
        public string PhoneNumber { get; set; }
        public string WebsiteURL { get; set; }
        public string UpdatedDate { get; set; }

        public Publishers(int publisherID, string name, string addressLine1, string addressLine2, string suburb, string city, int postcode, string phoneNumber, string websiteURL, string updatedDate)
        {
            PublisherID = publisherID;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Suburb = suburb;
            City = city;
            Postcode = postcode;
            PhoneNumber = phoneNumber;
            WebsiteURL = websiteURL;
            UpdatedDate = updatedDate;
        }
    }

    public class Retailers
    {
        public int RetailerID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string WebsiteURL { get; set; }
        public string EmailAddress { get; set; }
        public string UpdatedDate { get; set; }

        public Retailers(int retailerID, string name, string addressLine1, string addressLine2, string city, string phoneNumber, string websiteURL, string emialAddress, string updatedDate)
        {
            RetailerID = retailerID;
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            PhoneNumber = phoneNumber;
            WebsiteURL = websiteURL;
            EmailAddress = emialAddress;
            UpdatedDate = updatedDate;
        }
    }

    public class BookCopies
    {
        public decimal BookBarcode { get; set; }
        public int BookID { get; set; }
        public int RetailerID { get; set; }
        public decimal PurchasePrice { get; set; }
        public string RfidTag { get; set; }

        public BookCopies(decimal bookBarcode, int bookID, int retailerID, decimal purchasePrice, string rfidTag)
        {
            BookBarcode = bookBarcode;
            BookID = bookID;
            RetailerID = retailerID;
            PurchasePrice = purchasePrice;
            RfidTag = rfidTag;
        }
    }

    public class Customers
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public string DOB { get; set; }
        public string UpdatedDate { get; set; }

        public Customers(int customerID, string firstName, string lastName, string addressLine1, string addressLine2, string city, string phoneNumber, string dob, string updatedDate)
        {
            this.CustomerID = customerID;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.City = city;
            this.PhoneNumber = phoneNumber;
            this.DOB = dob;
            this.UpdatedDate = updatedDate;
        }
    }

    public class Users
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RfidTag { get; set; }
        public int CustomerID { get; set; }
        public string AccessLevel { get; set; }
        public string UpdatedDate { get; set; }

        public Users(string email, string password, string rfidTag, int customerID, string accessLevel, string updatedDate)
        {
            this.Email = email;
            this.Password = password;
            this.RfidTag = rfidTag;
            this.CustomerID = customerID;
            this.AccessLevel = accessLevel;
            this.UpdatedDate = updatedDate;
        }
    }

    public class Genres
    {
        public int GenreID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MinimumAge { get; set; }
        public string UpdatedDate { get; set; }

        public Genres(int genreID, string name, string description, int minimumAge, string updatedDate)
        {
            this.GenreID = genreID;
            this.Name = name;
            this.Description = description;
            this.MinimumAge = minimumAge;
            this.UpdatedDate = updatedDate;
        }
    }

    public class BooksOnHold
    {
        public int HoldID { get; set; }
        public int BookID { get; set; }
        public string Date { get; set; }
        public int CustomerID { get; set; }

        public BooksOnHold(int holdID, int bookID, string date, int customerID)
        {
            this.HoldID = holdID;
            this.BookID = bookID;
            this.Date = date;
            this.CustomerID = customerID;
        }
    }

    public class BooksIssued
    {
        public int IssueNumber { get; set; }
        public int CustomerID { get; set; }
        public int BookBarcode { get; set; }
        public string IssueDate { get; set; }
        public string DueDate { get; set; }
        public string ReturnedDate { get; set; }

        public BooksIssued(int customerID, int bookBarcode, string issueDate, string dueDate, string returnDate)
        {
            this.CustomerID = customerID;
            this.BookBarcode = bookBarcode;
            this.IssueDate = issueDate;
            this.DueDate = dueDate;
            this.ReturnedDate = returnDate;
        }
    }
}