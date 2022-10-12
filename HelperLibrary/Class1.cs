using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Linq.Expressions;

namespace HelperLibrary
{
    public class Bookmethods
    {
        libraryEntities context = null;
        public Bookmethods()
        {
            context = new libraryEntities();
        }
        public List<Book> getlist()
        {

            return context.Books.ToList();
        }
        public bool AddBook(Book b)
        {
            try
            {
                context.Books.Add(b);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool updatebook(int i, Book b)
        {
            try
            {
                List<Book> books = context.Books.ToList();
                Book s = books.Find(p => p.Book_No == i);
                s.Book_No = b.Book_No;
                s.Book_Name = b.Book_Name;
                s.Cost = b.Cost;
                s.Author = b.Author;
                s.Category = b.Category;
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
        public bool deletebook(int i)
        {
            try
            {
                List<Book> books = context.Books.ToList();
                Book s = books.Find(p => p.Book_No == i);
                context.Books.Remove(s);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public Book findbook(int i)
        {
            List<Book> books = context.Books.ToList();
            Book s = books.Find(p => p.Book_No == i);
            return s;
        }
    }
    public class membermethods
    {
        libraryEntities context = null;
        public membermethods()
        {
            context = new libraryEntities();
        }
        public bool addmember(member c)
        {
            try
            {
                context.members.Add(c);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool deletemember(int id)
        {
            try
            {
                List<member> ds = context.members.ToList();
                member dt = ds.Find(p => p.member_id == id);
                context.members.Remove(dt);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public member findmember(int id)
        {
            List<member> ds = context.members.ToList();
            member dt = ds.Find(p => p.member_id == id);
            return dt;

        }
        public List<member> GetMembers()
        {
            return context.members.ToList();
        }
        public bool updatemember(int id,member c)
        {
            try
            {
                List<member> ds = context.members.ToList();
                member dt = ds.Find(p => p.member_id == id);
                dt.member_id = c.member_id;
                dt.member_name = c.member_name;
                dt.Acc_open_date = c.Acc_open_date;
                dt.penaltyamount=c.penaltyamount;
                dt.maxbooksallowed = c.maxbooksallowed;
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
    public class issuemethods
    {
        libraryEntities context = null;
        public issuemethods()
        {
            context = new libraryEntities();

        }
        public bool AddIssue(Issue k)
        {
            try
            {
                context.Issues.Add(k);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool updateIssue(int id,Issue k)
        {
            try
            {
                List<Issue> k1 = context.Issues.ToList();
                Issue k2 = k1.Find(p => p.Lib_Issue_Id == id);
                k2.Lib_Issue_Id = k.Lib_Issue_Id;
                k2.Member_Id = k.Member_Id;
                k2.Book_No = k.Book_No;
                k2.Return_date = k.Return_date;
                k2.Issue_Date = k.Issue_Date;
                k2.comments = k.comments;
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public Issue findissue(int id)
        {
            Issue k = context.Issues.Find(id);
            return k;
        }
        public List<Issue> GetIssues()
        {
            return context.Issues.ToList();
        }
        public bool deleteIssue(int id)
        {
            try
            {
                List<Issue> k = context.Issues.ToList();
                Issue k1 = k.Find(p => p.Lib_Issue_Id == id);
                context.Issues.Remove(k1);
                context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
