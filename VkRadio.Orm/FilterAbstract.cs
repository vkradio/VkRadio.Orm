﻿namespace VkRadio.Orm
{
    public abstract class FilterAbstract
    {
        public abstract string? ToWhere();

        public abstract string? ToOrderBy();
    }
}
