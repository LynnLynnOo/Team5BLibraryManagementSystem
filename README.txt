# Team5BLibraryManagementSystem
################################################################################

                          Library Management System                           
                            Team-5B SA47 (NUS-ISS)                            
                               Contributed by
                               (1) Gao Jiaxue    (A#######W)                               
                               (2) Lynn Lynn Oo  (A#######W)
                               (3) Sam Jing Wen  (A#######W)
                               (4) Zan Tun Khine (A#######W)
                                               
################################################################################

This document contains summary of the Library Management System developed
by Team 5B from SA47 (NUS-ISS). 

################################################################################
                               Requirements
                              
It is necessary to do the following actions before running this application.

(1) Restore "Team12BSFMS.bak" file using Microsoft SQL Server Management Studio 
    before running this application.

(2) Add a new connection under server explorer using Visual Studio.

################################################################################
                                Contents  
                                    
(1) Summary
(2) Log_in 
(3) Books_Management 
(4) Members_Management
(5) Reports
(6) Log_out

################################################################################
                                (1) Summary
                                
This Library Management System application has got the following features.
(1) Book Management
(2) Member Management
(3) Report Generation

################################################################################
                                (2) Log_in


Following user names and passwords can be used to log into the system.
**************************
* Username  *   Password * 
**************************
*  Venkat   *   P@ssword *
**************************
* jingwen   *   jingwen  *
**************************
*   zan     *     zan    *
**************************
*  jiaxue   *    jiaxue  *
**************************
*  lynn     *    lynn    *
**************************

The passwords are encrypted and saved inside the database.

################################################################################
                                (3) Books_Management
                                
There are four features under the Books_Management feature.

(1) Search Books by different categories
    (a)Title
    (b)Author
    (c)BookID
    (d)Publisher
    (e)Category
    (f)Publisher Year
    (g)ISBN
    (h)Status
    (i)Location (Special feature)
    
(2) Add/Remove Books
(3) Update/Edit Books Information
(4) Loan/Return Books

################################################################################
                                (4) Members_Management                                

There are four features under the Members_Management feature.

(1) Search Members by different categories
(2) Add/Remove Members
(3) Update/Edit Member Information
(4) Renew Membership
(5) Check the transaction history

################################################################################
                                (5) Reports

The following reports can be generated using this feature.

(1) Book List
(2) Member List


################################################################################
                                (6) Log_out

The user can press the Logout button or windowsform close button to log out from 
the system.




