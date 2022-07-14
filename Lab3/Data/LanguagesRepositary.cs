using System.Text.Encodings;
using lab3.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Data
{
	public class LanguagesRepositary
	{
		private readonly LanguagesContext _languagesContext;

        public LanguagesRepositary(LanguagesContext languagesContext)
		{
			_languagesContext = languagesContext;
		}

		public void Add(LanguagesModel languagesModel)
		{
            _languagesContext.Languages.Add(languagesModel);
            _languagesContext.SaveChanges();
        }

        public void Update(LanguagesModel languagesModel)
        {
            _languagesContext.Languages.Update(languagesModel);
            _languagesContext.SaveChanges();
        }

        public void Delete(LanguagesModel languagesModel)
        {
            _languagesContext.Languages.Remove(languagesModel);
            _languagesContext.SaveChanges();
        }

        public LanguagesModel? Read(int id)
        {
            return _languagesContext.Languages.Include(x => x.LanguagesTypeModel).FirstOrDefault(x => x.Id == id);
        }

        public LanguagesModel[] ReadAll()
        {
            return _languagesContext.Languages.Include(x => x.LanguagesTypeModel).ToArray();
        }
    }
}