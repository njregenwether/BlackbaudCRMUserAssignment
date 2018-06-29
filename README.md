# BlackbaudCRMUserAssignment

This customization will add functionality to Blackbaud CRM to assign multiple roles and multiple sites to multiple users. This also allows for deletion. 

This customization also includes a "Make Like" feature that allows someone to assign roles to someone using another application user as a template. 


# To Deploy
1. Build this customization
2. Put the dlls and html files where they need to go. 
3. Load the package 
4. Add roles to the configuration tables (located in Administration -> Security -> User Role Adjustment
  a. Look on the tab for configuration. 
  b. You'll see 2 data lists, one has sites which are always assigned as "All sites", the other is for roles with "No sites" assigned.
5. You will see the functions in the explorer bar of this page that allow for assigning roles. 

Note: This has site security enabled. If your organization doesn't use site security, alter this as appropriate. 
