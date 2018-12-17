namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// An edit on user content
    /// </summary>
    public class UserContentEdit : QueryableValue<UserContentEdit>
    {
        internal UserContentEdit(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// Identifies the date and time when the object was created.
        /// </summary>
        public DateTimeOffset CreatedAt { get; }

        /// <summary>
        /// Identifies the date and time when the object was deleted.
        /// </summary>
        public DateTimeOffset? DeletedAt { get; }

        /// <summary>
        /// The actor who deleted this content
        /// </summary>
        public IActor DeletedBy => this.CreateProperty(x => x.DeletedBy, Octokit.GraphQL.Model.Internal.StubIActor.Create);

        /// <summary>
        /// A summary of the changes for this edit
        /// </summary>
        public string Diff { get; }

        /// <summary>
        /// When this content was edited
        /// </summary>
        public DateTimeOffset EditedAt { get; }

        /// <summary>
        /// The actor who edited this content
        /// </summary>
        public IActor Editor => this.CreateProperty(x => x.Editor, Octokit.GraphQL.Model.Internal.StubIActor.Create);

        [SuppressMessage("System.Diagnostics", "CS1591", Justification = "Source did not provide detail")]
        public ID Id { get; }

        /// <summary>
        /// Identifies the date and time when the object was last updated.
        /// </summary>
        public DateTimeOffset UpdatedAt { get; }

        internal static UserContentEdit Create(Expression expression)
        {
            return new UserContentEdit(expression);
        }
    }
}