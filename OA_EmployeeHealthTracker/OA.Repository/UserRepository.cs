﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OA.Data;

namespace OA.Repository
{
    class UserRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext context;
        private DbSet<T> entitites;
        public UserRepository(ApplicationContext context)
        {
            this.context = context;
            this.entitites = context.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            entitites.Remove(entity);
            context.SaveChanges();
        }

        public T get(long id)
        {
            return entitites.SingleOrDefault(s => s.ID == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entitites.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entity==null)
            {
                throw new ArgumentNullException("Empty");
            }
            entitites.Add(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            entitites.Remove(entity);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("Empty");
            }
            context.SaveChanges();
        }
    }
}
