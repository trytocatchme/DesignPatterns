﻿namespace ChainOfResponsiblity.Spec
{
    public static class SpecificationExtensions
    {
        public static Specification<T> And<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            if (left != null && right != null)
            {
                return new Specification<T>(o => left.IsSatisfiedBy(o) && right.IsSatisfiedBy(o));
            }
            return null;
        }

        public static Specification<T> Or<T>(this ISpecification<T> left, ISpecification<T> right)
        {
            if (left != null && right != null)
            {
                return new Specification<T>(o => left.IsSatisfiedBy(o) || right.IsSatisfiedBy(o));
            }
            return null;
        }

        public static Specification<T> Not<T>(this ISpecification<T> left)
        {
            if (left != null)
            {
                return new Specification<T>(o => !left.IsSatisfiedBy(o));
            }
            return null;
        }
    }
}