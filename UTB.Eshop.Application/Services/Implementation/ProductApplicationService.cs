using System;
using System.Collections.Generic;
using System.Linq;
using UTB.Eshop.Application.Services.Abstraction;
using UTB.Eshop.Domain.Entities;
using UTB.Eshop.Infrastructure.Database;

namespace UTB.Eshop.Application.Services.Implementation
{

    //ve tride je vytvorena skareda zavislost na entity frameworku core
    //zbavime se ji vytvorenim abstrakce pro domenovou vrstvu ->
    //                  s vyuzitim repository patternu a vytvoreni sluzeb pro jednotlive entity
    //                  (napr. pro Product -> IProductRepository, IProductService + implementace ProductService)
    //potom taky s vyuzitim unit of work ve vrstve infrastructure ->
    //                  (IUnitOfWork + implementace UnitOfWork)
    //a s implementaci repozitare pro entity ve vrstve infrastructure ->
    //                  (napr. ProductRepository)
    //a nakonec taky vyuzitim vyse zminenych abstrakci/interfacu v teto tride ;-)
    //pro zjednoduseni to dame vse do jedne vrstvy, ale pokud si chcete vyzkouset optimalizaci rozdelenim na jednotlive vrstvy, tak jen smele do toho ;-)
    //                  (take je dobre si vytvorit projekty v kazde vrstve zvlast pro abstrakci a zvlast pro implementaci)

    public class ProductApplicationService : IProductApplicationService
    {
        EshopDbContext _eshopDbContext;

        public ProductApplicationService(EshopDbContext eshopDbContext)
		{
            _eshopDbContext = eshopDbContext;
        }


        public IList<Product> GetAllProducts()
        {
            return _eshopDbContext.Products.ToList();
        }


        public Product GetProduct(int ID)
        {
            return _eshopDbContext.Products.FirstOrDefault(product => product.ID == ID);
        }
    }
}

