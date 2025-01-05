# Barbershop Operations Platform
People spend countless hours at barbershops, waiting for their turn to get their haircut. The process is
inefficient as there could be long waiting lists at the barber, delaying everyone and causing frustration among
customers.

The goal of this platform is to streamline everyday operations and improve customer experience by developing
an integrated barbershop management system. Customers can use the system to schedule appointments, save
their haircut details, track loyalty points, and provide feedback. By enabling clients to easily track their
appointments, the barbershop can provide a more seamless booking experience. To reward loyalty points,
customers could pay using loyalty points.

From an operational point of view, the platform assists barbers in tracking their schedules, updating
appointment statuses, while offering a simple request system for days off. To create a more productive work
environment, receptionists are given the resources they need to assign barbers to appointments, and process
offline payments. The manager can also access detailed reports that include financial statistics, supply data,
and customer and barber histories. This well-rounded system not only increases workplace efficiency but also
enables personalized service, contributing to a modernised and customer-centric barbershop experience.

## System Users and Priveleges
### Customer
* Creates an account
* Views points, appointment history, and account details (attributes: fav barber, haircut details, etc).
* Reserves an appointment and gives feedback regarding it
* Pays for appointment (online payment, offline payment at branch, using points)
* Updates account details and preferences

### Barber
* Views appointments schedule
* Requests days off
* Requests supplies
* Logs his attendance
* Submits incident reports
* Views and manages personal information.

### Receptionist
* Manages appointments (assign barbers)
* Adds appointments made via phone or in store
* Supervises payment transactions
* Requests days off
* Views and manages personal information

### Manager
* Views and manages personal information
* Adds or removes Barbers and Receptionists
* Views barbers' and customers' histories
* Approves days off
* Approves supply request
* Views financial statistics
* Creates offers
* Receives service feedback and incident reports
* SuperManager can add and update Managers
