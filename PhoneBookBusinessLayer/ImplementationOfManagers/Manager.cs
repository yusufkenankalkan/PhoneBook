﻿using AutoMapper;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.ResultModels;
using System.Linq.Expressions;

namespace PhoneBookBusinessLayer.ImplementationOfManagers
{
    public class Manager<TViewModel, TModel, Id> : IManager<TViewModel, Id> where TViewModel : class, new() where TModel : class, new()
    {
        protected readonly IRepository<TModel, Id> _repo;
        protected readonly IMapper _mapper;
        protected readonly string _includeRelationalTables;

        public Manager(IRepository<TModel, Id> repo, IMapper mapper, string includeRelationalTables)
        {
            _repo = repo;
            _mapper = mapper;
            _includeRelationalTables = includeRelationalTables;
        }

        public IDataResult<TViewModel> Add(TViewModel model)
        {
            try
            {
                //Bize parametre olarak gelen DTO'yu repoya gönderemiyoruz. Repoya modelin kendisi gönderilmelidir.
                TModel tmodel = _mapper.Map<TViewModel, TModel>(model);
                int result = _repo.Add(tmodel); //tmodel repo ile veritabanına eklendi tmodelin artık idsi var.
                TViewModel dataModel = _mapper.Map<TModel, TViewModel>(tmodel);
                return result > 0 ? new DataResult<TViewModel>(dataModel, "Ekleme işlemi Başarılı", true) :
                    new DataResult<TViewModel>(model, "Ekleme Başarısız", false);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IResult Delete(TViewModel model)
        {
            try
            {
                TModel tmodel = _mapper.Map<TViewModel, TModel>(model);
                if (_repo.Delete(tmodel) > 0)
                {
                    return new Result(true, "Silme işlemi gerçekleşti");
                }
                else
                {
                    return new Result(false);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IDataResult<ICollection<TViewModel>> GetAll(Expression<Func<TViewModel, bool>>? filter = null)
        {
            try
            {
                var fltr = _mapper.Map<Expression<Func<TViewModel, bool>>, Expression<Func<TModel, bool>>>(filter);
                var data = _repo.GetAll(fltr, _includeRelationalTables?.Split(","));

                ICollection<TViewModel> dataList = _mapper.Map<IQueryable<TModel>, ICollection<TViewModel>>(data);
                return new DataResult<ICollection<TViewModel>>(dataList, "", true);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<TViewModel> GetByConditions(Expression<Func<TViewModel, bool>>? filter = null)
        {
            try
            {
                var fltr = _mapper.Map<Expression<Func<TViewModel, bool>>, Expression<Func<TModel, bool>>>(filter);
                var data = _repo.GetByConditions(fltr, _includeRelationalTables?.Split(","));
                if(data == null)
                {
                    return new DataResult<TViewModel>(false, null);
                }
                else
                {
                    var dataModel = _mapper.Map<TModel,TViewModel>(data);
                    return new DataResult<TViewModel>(true,dataModel);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IDataResult<TViewModel> GetById(Id id)
        {
            if (id == null)
            {
                return new DataResult<TViewModel>(false, null);
            }
            else
            {
                var data = _repo.GetById(id);
                if (data == null)
                {
                    return new DataResult<TViewModel>(null, "Kayıt Bulunamadı", false);

                }
                TViewModel dataModel = _mapper.Map<TModel, TViewModel>(data);
                return new DataResult<TViewModel>(dataModel, "Kayıt Bulundu", true);
            }
        }

        public IResult Update(TViewModel model)
        {
            try
            {
                TModel tmodel = _mapper.Map<TViewModel, TModel>(model);
                int result = _repo.Update(tmodel);
                if (result > 0)
                {
                    return new Result(true, "Güncelleme işlemi Başarılı");
                }
                else
                {
                    return new Result(false, "Güncelleme işlemi başarısız");
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
