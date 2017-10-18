// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Veises.SocialNet.Identity.Contracts.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// User identity model
    /// </summary>
    public partial class UserIdentity
    {
        /// <summary>
        /// Initializes a new instance of the UserIdentity class.
        /// </summary>
        public UserIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserIdentity class.
        /// </summary>
        /// <param name="isBlocked">Describes user identity is blocked</param>
        /// <param name="userName">User display name</param>
        /// <param name="userUid">User unique identifier</param>
        public UserIdentity(bool isBlocked, string userName, UserUid userUid)
        {
            IsBlocked = isBlocked;
            UserName = userName;
            UserUid = userUid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes user identity is blocked
        /// </summary>
        [JsonProperty(PropertyName = "isBlocked")]
        public bool IsBlocked { get; set; }

        /// <summary>
        /// Gets or sets user display name
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets user unique identifier
        /// </summary>
        [JsonProperty(PropertyName = "userUid")]
        public UserUid UserUid { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (UserName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserName");
            }
            if (UserUid == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "UserUid");
            }
            if (UserName != null)
            {
                if (UserName.Length > 25)
                {
                    throw new ValidationException(ValidationRules.MaxLength, "UserName", 25);
                }
                if (UserName.Length < 25)
                {
                    throw new ValidationException(ValidationRules.MinLength, "UserName", 25);
                }
            }
        }
    }
}