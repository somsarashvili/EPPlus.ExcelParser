﻿using EPPlus.ExcelParser.Shared;
using OfficeOpenXml;
using System;

namespace EPPlus.ExcelParser.Parsing.Mapper
{
    internal class DefaultMappingProvider<TObject> : IRowMapper<TObject> where TObject : class
    {
        private ExcelMapper<TObject> _mapper;

        public DefaultMappingProvider(ExcelMapper<TObject> mapper)
        {
            _mapper = mapper;
        }

        public TObject Map(ExcelWorksheet worksheet, int row)
        {
            return _mapper.MapFromExcel(worksheet, row);
        }
    }
}
