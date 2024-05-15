<H1  > Clinic Management System </H1>
</br>
This is a comprehensive clinic management system that allows you to efficiently manage patient records, doctor information, appointments, medical records, prescriptions, and payments.

It follows a three-tier architecture consisting of the Data Access Layer, Business Layer, and Presentation Layer for maintainability and scalability.
</br>

<H2> Features </H2>
</br>
<H4> 1. Patients </H4>
The system stores detailed information about patients. Each patient is assigned a unique identifier, and their profile includes their name, date of birth, gender, contact information (phone number, email), and address.

<H4>2. Doctors </H4>
The system maintains a comprehensive database of doctors. Each doctor is assigned a unique identifier, and their profile includes their name, specialization, date of birth, gender, contact information (phone number, email), and address.

<H4>3. Appointments</H4>
The system manages appointments effectively. Each appointment is assigned a unique identifier and includes the patient, doctor, appointment date and time, and appointment status. Appointment statuses include:

<p>Pending: The appointment has been scheduled but has not yet occurred.</p>
<p>Confirmed: The appointment has been confirmed by both the patient and the healthcare provider.</p>
<p>Completed: The appointment has taken place as scheduled.</p>
<p>Canceled: The appointment has been canceled either by the patient or the healthcare provider.</p>
<p>Rescheduled: The appointment has been rescheduled for a different date or time.</p>
<p>No Show: The patient did not show up for the appointment without canceling or rescheduling.</p>

<H4>4. Medical Records</H4>
The system maintains comprehensive medical records for patients. Each attended appointment is associated with a medical record. Each medical record is assigned a unique identifier and includes the patient, doctor, description of the visit, diagnosis, prescribed medication, and any additional notes.

<H4>5. Prescription</H4>
The system manages prescribed medications efficiently. For each medical record, there can be at most one prescription. Each prescription is assigned a unique identifier and includes the medical record, medication name, dosage, frequency, start date, end date, and any special instructions.

<H4>6. Payments</H4>
The system tracks payment information for appointments. Each payment is assigned a unique identifier and includes the patient, payment date, payment method, amount paid, and any additional notes. Payments are associated with individual appointments.

<H2> Technology Used </H2>
</br>
The clinic management system is built using the following technologies:
<p> Programming Language : C#</p>
<p> Framework: .NET Framework</p>
<p> Database : Ms SQL Server</p>
<p> Data Access : ADO.NET</p>
<p> User Interface : WinForms</p>
<p> Integrated Development Environment : Visual Studio</p>
</br>
<p>To see a demo of the project <a style="margin-left: 40px;" target="_blank" href="https://youtu.be/vBZQVXpOF1s?si=KwhFc3kcmdsJxhYT">click here</a></p>
