using BookStore.Enums;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BookStore.Repository
{
    public class BookRepository : IRepository<BookModel>
    {
        private readonly string _dataFile = @"Data\data.xml";
        private readonly XmlSerializer _serializer = new XmlSerializer(typeof(HashSet<BookModel>));
        public List<BookModel> _bookModels;
        public BookRepository()
        {
            if (!File.Exists(_dataFile))
            {
                _bookModels = new List<BookModel>()
                {
                    new BookModel()
                    {
                        Id = 1, Name = "Call of the wild", CategoryId = (int)CategoryEnum.NonFiction, Author = "Jack London", Publisher = "Kim Dong", PublishedDate = new DateTime(2020, 01, 01), Description = "Tieu thuyet"
                    },
                    new BookModel()
                    {
                        Id = 2, Name = "Arita", CategoryId = (int)CategoryEnum.Fiction, Author = "Haramuki Murukami", Publisher = "Tien Hai", PublishedDate = new DateTime(2019, 11, 09), Description = "Vien Tuong"
                    },
                    new BookModel()
                    {
                        Id = 3, Name = "Day con lam giau", CategoryId = (int)CategoryEnum.Education, Author = "Tony Buzan", Publisher = "AlphaBook", PublishedDate = new DateTime(2015, 07, 04), Description = "Giao duc con lam giau"
                    }
                };
            }
            else
            {
                using FileStream stream = File.OpenRead(_dataFile);
                _bookModels = _serializer.Deserialize(stream) as List<BookModel>;
            }
        }
            
        public List<BookModel> List()
        {
            return _bookModels;
        }
        public BookModel Get(int id)
        {
            if (id <= 0)
            {
                return new BookModel();
            }
            return _bookModels.Find(x => x.Id == id);
        }
        public void Create(BookModel bookModel)
        {
            if (bookModel != null)
            {
                if (!_bookModels.Any(x => x.Name == bookModel.Name && x.Author == bookModel.Author))
                {
                    bookModel.Id = _bookModels.OrderByDescending(x => x.Id).First().Id + 1;
                    _bookModels.Add(bookModel);
                }
            }
        }
        public void Edit(BookModel bookModel)
        {
            if (bookModel != null)
            {
                if (_bookModels.Any(x => x.Id == bookModel.Id))
                {
                    _bookModels.Remove(_bookModels.Find(x => x.Id == bookModel.Id));
                    _bookModels.Add(bookModel);
                }
            }
        }
        public void Delete(int id)
        {
            if (id > 0)
            {
                if (_bookModels.Any(x => x.Id == id))
                {
                    _bookModels.Remove(_bookModels.Find(x => x.Id == id));
                }
            }
        }

        public void SaveChanges()
        {
            using FileStream stream = File.Create(_dataFile);
            _serializer.Serialize(stream, _bookModels);
        }
    }
}
