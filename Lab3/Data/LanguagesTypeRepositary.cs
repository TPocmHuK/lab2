using System.Text.Encodings;
using lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
    public class LanguagesModelRepositary
    {
        private readonly LanguagesContext _languagesContext;

        public LanguagesModelRepositary(LanguagesContext languagesContext)
        {
            _languagesContext = languagesContext;
        }

        public void Add(LanguagesTypeModel languagesTypeModel)
        {
            _languagesContext.LanguagesType.Add(languagesTypeModel);
            _languagesContext.SaveChanges();
        }

        public void Update(LanguagesTypeModel languagesTypeModel)
        {
            _languagesContext.LanguagesType.Update(languagesTypeModel);
            _languagesContext.SaveChanges();
        }

        public void Delete(LanguagesTypeModel languagesTypeModel)
        {
            _languagesContext.LanguagesType.Remove(languagesTypeModel);
            _languagesContext.SaveChanges();
        }

        public LanguagesTypeModel? Read(int id)
        {
            return _languagesContext.LanguagesType.Include(x => x.LanguagesModels).FirstOrDefault(x => x.Id == id);
        }

        public LanguagesTypeModel[] ReadAll()
        {
            return _languagesContext.LanguagesType.Include(x => x.LanguagesModels).ToArray();
        }
    }
}