﻿using System;

namespace Drexel.DataSources
{
    /// <summary>
    /// Represents a factory which produces <typeparamref name="T"/>s from <see cref="IConfigurationRequirement"/>s.
    /// </summary>
    /// <typeparam name="T">
    /// The <see cref="Type"/> of <see cref="object"/> the <see cref="IDataSource{T}"/>s generated by this factory will
    /// contain.
    /// </typeparam>
    public interface IDataSourceFactory<T> : IConfigurable
    {
        /// <summary>
        /// Produces an <see cref="IDataSource{T}"/> instance using the supplied <paramref name="configuration"/>.
        /// </summary>
        /// <param name="configuration">
        /// The <see cref="IConfiguration"/> to use when producing the <see cref="IDataSource{T}"/>.
        /// </param>
        /// <returns>
        /// An <see cref="IDataSource{T}"/> produced from the supplied <paramref name="configuration"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Occurs when the supplied <see cref="IConfiguration"/> <paramref name="configuration"/> cannot be used by
        /// this <see cref="IDataSourceFactory{T}"/> to generate an <see cref="IDataSource{T}"/>.
        /// </exception>
        IDataSource<T> MakeDataSource(IConfiguration configuration);
    }
}
