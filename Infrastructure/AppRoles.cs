using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCM.ProfitCenter.Infrastructure
{
    /// <summary>
    /// Contains a list of all the Azure AD app roles this app depends on and works with.
    /// </summary>
    public static class AppRole
    {
        /// <summary>
        /// User can manage theri own profit center
        /// </summary>
        public const string ProfitCenterUser = "ProfitCenterUser";

        /// <summary>
        /// Admins can manage the profit center.
        /// </summary>
        public const string ProfitCenterAdmin = "ProfitCenterAdmin";

        /// <summary>
        /// User readers can read basic profiles of all users in the directory.
        /// </summary>
        public const string UserReaders = "UserReaders";

        /// <summary>
        /// Directory viewers can view objects in the whole directory.
        /// </summary>
        public const string DirectoryViewers = "DirectoryViewers";
    }

    /// <summary>
    /// Wrapper class the contain all the authorization policies available in this application.
    /// </summary>
    public static class AuthorizationPolicies
    {
        public const string ProfitCenterUser = "AssignmentToProfitCenterUserRoleRequired";
        public const string ProfitCenterAdmin= "AssignmentToProfitCenterAdminRoleRequired";
        public const string AssignmentToUserReaderRoleRequired = "AssignmentToUserReaderRoleRequired";
        public const string AssignmentToDirectoryViewerRoleRequired = "AssignmentToDirectoryViewerRoleRequired";
    }
}
