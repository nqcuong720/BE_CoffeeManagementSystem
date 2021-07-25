﻿// <copyright file="SizeEntities.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using CoffeeManagementSystem.Model.BaseModel;

namespace CoffeeManagementSystem.Model.EntitiesModel
{
    public class SizeEntities : BaseTableWithId
    {
        /// <summary>
        /// Gets or sets tên size.
        /// </summary>
        public string SizeName { get; set; }

        /// <summary>
        /// Gets or sets price.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets product.
        /// </summary>
        public int ProductId { get; set; }
    }
}