using System;
using System.Collections.Generic;
using System.Text;

namespace WriteAway.Core
{
    /// <summary>
    /// Base entity of every Domain object.
    /// Inherit this to be able to Inject to the repository.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseEntity<T>
    {
        /// <summary>
        /// Id.  If Id is type Guid you MUST assign it in the constructor.
        /// </summary>
        public T Id { get; set; }

        public BaseEntity()
        {
        }
    }
}
