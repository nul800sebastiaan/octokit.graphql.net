namespace Octokit.GraphQL.Model
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq.Expressions;
    using Octokit.GraphQL.Core;
    using Octokit.GraphQL.Core.Builders;

    /// <summary>
    /// Autogenerated return type of AddProjectColumn
    /// </summary>
    public class AddProjectColumnPayload : QueryableValue<AddProjectColumnPayload>
    {
        internal AddProjectColumnPayload(Expression expression) : base(expression)
        {
        }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; }

        /// <summary>
        /// The edge from the project's column connection.
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `columnEdge` will change from `ProjectColumnEdge!` to `ProjectColumnEdge`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public ProjectColumnEdge ColumnEdge => this.CreateProperty(x => x.ColumnEdge, Octokit.GraphQL.Model.ProjectColumnEdge.Create);

        /// <summary>
        /// The project
        /// **Upcoming Change on 2019-01-01 UTC**
        /// **Description:** Type for `project` will change from `Project!` to `Project`.
        /// **Reason:** In preparation for an upcoming change to the way we report mutation errors, non-nullable payload fields are becoming nullable.
        /// </summary>
        public Project Project => this.CreateProperty(x => x.Project, Octokit.GraphQL.Model.Project.Create);

        internal static AddProjectColumnPayload Create(Expression expression)
        {
            return new AddProjectColumnPayload(expression);
        }
    }
}