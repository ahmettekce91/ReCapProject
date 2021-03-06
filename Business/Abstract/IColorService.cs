﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetAllByCategoryId(int id);
        void Add(Color color);
        void Update(Color color);
        void Delete(Color color);
    }
}
