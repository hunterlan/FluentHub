namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateEnterpriseOrganizationProjectsSetting
    /// </summary>
    public class UpdateEnterpriseOrganizationProjectsSettingInput
    {
        /// <summary>
        /// The ID of the enterprise on which to set the organization projects setting.
        /// </summary>
        public ID EnterpriseId { get; set; }

        /// <summary>
        /// The value for the organization projects setting on the enterprise.
        /// </summary>
        public EnterpriseEnabledDisabledSettingValue SettingValue { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}