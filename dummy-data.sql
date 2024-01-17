-- Insert data into Professionals
INSERT INTO Professionals (Id, Name, EstablishmentType, ManagementType, Address_Street, Address_City, Address_PostalCode, PhoneNumber, Email, ContactPerson_Name, ContactPerson_Function, ContactPerson_PhoneNumber, ContactPerson_Email, Geolocation_Latitude, Geolocation_Longitude, Description, CreationDateTime, ValidationStatusId)
VALUES
    ('14e8f8c3-1537-40d5-bb5a-1d90d7d9c500', 'Johns Clinic', 'Hospital', 'Private', '123 Medical St', 'Cityville', '12345', 0917837489, 'johnsclinic@example.com', 'John Doe', 'Owner', 0173647283, 'john.doe@example.com', 45.123, 1.456, 'A leading medical clinic in Cityville', '2023-12-19T12:34:56', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('2747c3a4-1f79-4f1b-8525-c1a54b17224a', 'Tech Solutions Inc.', 'Technology', 'Corporate', '456 Tech Blvd', 'Tech City', '54321', 0776283945, 'techsolutions@example.com', 'Jane Smith', 'IT Manager', 0917628934, 'jane.smith@example.com', 43.789, 1.123, 'Providing cutting-edge technology solutions', '2023-12-19T13:45:00', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('3d7d9eb3-aa53-4e8c-8ee7-b8ac511f8c8a', 'Green Thumb Landscapes', 'Landscaping', 'Small Business', '789 Green St', 'Naturetown', '67890', 0862777381, 'greenthumb@example.com', 'Sam Green', 'Landscaper', 0617890273, 'sam.green@example.com', 43.641, 1.488, 'Creating beautiful landscapes for homes and businesses', '2023-12-19T14:56:23', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('ac6e46a3-c36a-4c54-bc17-689fe29f450b', 'Healthy Smiles Dental', 'Dental Clinic', 'Private', '789 Dentist Ave', 'Toothville', '56789', 0912345678, 'healthysmiles@example.com', 'Dr. Sarah Johnson', 'Dentist', 0123456789, 'sarah.johnson@example.com', 42.567, 0.890, 'Providing top-notch dental care in Toothville', '2023-12-19T15:45:00', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('dd1f3985-38fc-4ba3-80c0-67b987b33257', 'Tech Innovators Ltd.', 'IT Services', 'Startup', '101 Innovator St', 'Techland', '12345', 0987654321, 'techinnovators@example.com', 'Alex Turner', 'CEO', 0765432109, 'alex.turner@example.com', 43.597, 1.317, 'Innovating the future with cutting-edge technology', '2023-12-19T16:34:12', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('1a390e1a-6626-4e27-925b-9d349ab475e4', 'Blossom Gardens Nursery', 'Landscaping', 'Small Business', '456 Bloom St', 'Gardentown', '34567', 0654321098, 'blossomgardens@example.com', 'Emily Green', 'Botanist', 0789012345, 'emily.green@example.com', 41.321, 1.543, 'Specializing in beautiful garden designs and plant care', '2023-12-19T17:23:45', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('f8a0e89d-3f8d-489e-8394-b59445c7e865', 'City Gym & Fitness', 'Fitness Center', 'Private', '987 Fit St', 'Workout City', '87654', 0932109876, 'citygym@example.com', 'Chris Fitness', 'Owner', 0654321098, 'chris.fitness@example.com', 43.581, 1.458, 'Your ultimate destination for fitness and health', '2023-12-19T18:12:34', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('f824ce77-5b1a-4c6a-9151-bb1da1a704ac', 'Sunrise Pharmacy', 'Pharmacy', 'Independent', '567 Health Blvd', 'Medtown', '98765', 0908765432, 'sunrisepharmacy@example.com', 'Lisa Davis', 'Pharmacist', 0123456789, 'lisa.davis@example.com', 43.789, 1.567, 'Your trusted neighborhood pharmacy', '2023-12-19T19:01:23', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('c648be6a-36e9-419c-9f79-14fe7b864c6d', 'Slick Design Studios', 'Design Agency', 'Creative', '234 Creativity Lane', 'Artville', '23456', 0765432109, 'slickdesigns@example.com', 'Mark Foster', 'Creative Director', 0987654321, 'mark.foster@example.com', 43.890, 1.789, 'Transforming ideas into visually stunning designs', '2023-12-19T19:50:45', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', 'Green Living Landscapes', 'Landscaping', 'Small Business', '789 Eco St', 'Green City', '34567', 0654321098, 'greenliving@example.com', 'Anna Green', 'Landscape Architect', 0789012345, 'anna.green@example.com', 43.321, 1.543, 'Creating sustainable and beautiful outdoor spaces', '2023-12-19T20:40:01', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', 'FitFuel Nutrition', 'Nutritionist', 'Private', '876 Nutrient Ave', 'Healthtown', '87654', 0932109876, 'fitfuelnutrition@example.com', 'Mike Turner', 'Nutritionist', 0654321098, 'mike.turner@example.com', 42.890, 2.123, 'Fueling your health with personalized nutrition plans', '2023-12-19T21:30:20', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('d8d33c54-1e87-4ab6-a6a8-6c9269474a4d', 'EcoTech Solutions', 'Environmental Services', 'Green Business', '123 Eco Ave', 'Greenville', '54321', 0912345678, 'ecotech@example.com', 'Emma Green', 'Environmental Specialist', 0123456789, 'emma.green@example.com', 43.594, 1.432, 'Promoting eco-friendly solutions for a sustainable future', '2023-12-19T22:20:12', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('4b6141f8-481c-4eb7-8f5c-aa6e7a6c67b4', 'Pet Paradise Veterinary Clinic', 'Veterinary Clinic', 'Private', '456 Pet Blvd', 'Animaltown', '98765', 0987654321, 'petparadisevet@example.com', 'Dr. James Smith', 'Veterinarian', 0765432109, 'james.smith@example.com', 44.890, 0.789, 'Caring for your pets with passion and expertise', '2023-12-19T23:10:45', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('1d0ed49a-149b-4654-98a5-8f39cfd0abf4', 'Artisan Coffee Roasters', 'Coffee Shop', 'Local Business', '789 Brew St', 'Coffeetown', '23456', 0654321098, 'artisancoffee@example.com', 'Sophie Baker', 'Barista', 0789012345, 'sophie.baker@example.com', 41.321, 0.543, 'Serving handcrafted coffee with love and precision', '2023-12-20T00:01:00', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)),
    ('2f69b399-c270-4a9b-81fb-64a35421828a', 'Cozy Book Nook', 'Bookstore', 'Independent', '876 Reading Lane', 'Bookville', '87654', 0932109876, 'cozybooknook@example.com', 'David Reader', 'Owner', 0654321098, 'david.reader@example.com', 43.890, 1.123, 'A haven for book lovers and literary enthusiasts', '2023-12-20T01:34:56', (SELECT Id FROM ValidationStatuses ORDER BY ValidationStatuses.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY));

-- Insert data into ProfessionalsMissions
INSERT INTO ProfessionalsMissions (ProfessionalId, MissionId)
VALUES
  ('14e8f8c3-1537-40d5-bb5a-1d90d7d9c500', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 1, Mission 1
  ('14e8f8c3-1537-40d5-bb5a-1d90d7d9c500', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 1, Mission 2
  ('2747c3a4-1f79-4f1b-8525-c1a54b17224a', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 2, Mission 3
  ('2747c3a4-1f79-4f1b-8525-c1a54b17224a', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 2, Mission 4
  ('3d7d9eb3-aa53-4e8c-8ee7-b8ac511f8c8a', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 3, Mission 5
  ('ac6e46a3-c36a-4c54-bc17-689fe29f450b', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 5 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 4, Mission 6
  ('dd1f3985-38fc-4ba3-80c0-67b987b33257', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 5, Mission 1
  ('dd1f3985-38fc-4ba3-80c0-67b987b33257', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 6 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 5, Mission 7
  ('1a390e1a-6626-4e27-925b-9d349ab475e4', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 6, Mission 4
  ('1a390e1a-6626-4e27-925b-9d349ab475e4', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 6, Mission 5
  ('1a390e1a-6626-4e27-925b-9d349ab475e4', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 7 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 6, Mission 8
  ('f8a0e89d-3f8d-489e-8394-b59445c7e865', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 6 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 7, Mission 7
  ('f824ce77-5b1a-4c6a-9151-bb1da1a704ac', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Mission 1
  ('f824ce77-5b1a-4c6a-9151-bb1da1a704ac', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Mission 3
  ('c648be6a-36e9-419c-9f79-14fe7b864c6d', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 7 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Mission 8
  ('f824ce77-5b1a-4c6a-9151-bb1da1a704ac', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 13 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Mission 14
  ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 9, Mission 2
  ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 5 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 9, Mission 6
  ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 7 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 9, Mission 8
  ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 8 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 9, Mission 9
  ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 10, Mission 3
  ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 10, Mission 5
  ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 6 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 10, Mission 7
  ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 10 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 10, Mission 11
  ('d8d33c54-1e87-4ab6-a6a8-6c9269474a4d', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 12 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 11, Mission 13
  ('4b6141f8-481c-4eb7-8f5c-aa6e7a6c67b4', (SELECT Id FROM Missions ORDER BY Missions.Id OFFSET 10 ROWS FETCH NEXT 1 ROW ONLY)); -- Professional 12, Mission 11
  
-- Insert data into ProfessionalsAudiences
INSERT INTO ProfessionalsAudiences (ProfessionalId, AudienceId)
VALUES
  ('14e8f8c3-1537-40d5-bb5a-1d90d7d9c500', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 1, Audience 1
  ('14e8f8c3-1537-40d5-bb5a-1d90d7d9c500', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 1, Audience 2
  ('2747c3a4-1f79-4f1b-8525-c1a54b17224a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 2, Audience 3
  ('3d7d9eb3-aa53-4e8c-8ee7-b8ac511f8c8a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 3, Audience 1
  ('3d7d9eb3-aa53-4e8c-8ee7-b8ac511f8c8a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 3, Audience 2
  ('3d7d9eb3-aa53-4e8c-8ee7-b8ac511f8c8a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 3, Audience 4
  ('3d7d9eb3-aa53-4e8c-8ee7-b8ac511f8c8a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 3, Audience 5
  ('ac6e46a3-c36a-4c54-bc17-689fe29f450b', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 4, Audience 5
  ('dd1f3985-38fc-4ba3-80c0-67b987b33257', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 5 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 5, Audience 6
  ('1a390e1a-6626-4e27-925b-9d349ab475e4', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 6, Audience 1
  ('1a390e1a-6626-4e27-925b-9d349ab475e4', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 6, Audience 3
  ('f8a0e89d-3f8d-489e-8394-b59445c7e865', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 7, Audience 3
  ('f824ce77-5b1a-4c6a-9151-bb1da1a704ac', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Audience 4
  ('c648be6a-36e9-419c-9f79-14fe7b864c6d', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 9, Audience 5
  ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 10, Audience 2
  ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 5 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 10, Audience 6
  ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 11, Audience 3
  ('d8d33c54-1e87-4ab6-a6a8-6c9269474a4d', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 12, Audience 4
  ('4b6141f8-481c-4eb7-8f5c-aa6e7a6c67b4', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 5 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 12, Audience 6
  ('1d0ed49a-149b-4654-98a5-8f39cfd0abf4', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 13, Audience 2
  ('1d0ed49a-149b-4654-98a5-8f39cfd0abf4', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 13, Audience 4
  ('1d0ed49a-149b-4654-98a5-8f39cfd0abf4', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 13, Audience 5
  ('2f69b399-c270-4a9b-81fb-64a35421827a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 14, Audience 1
  ('2f69b399-c270-4a9b-81fb-64a35421827a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 4 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 14, Audience 5
  ('2f69b399-c270-4a9b-81fb-64a35421827a', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 5 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 14, Audience 6
  ('dd1f3985-38fc-4ba3-80c0-67b987b33257', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 15, Audience 2
  ('dd1f3985-38fc-4ba3-80c0-67b987b33257', (SELECT Id FROM Audiences ORDER BY Audiences.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)); -- Professional 15, Audience 3
  
-- Insert data into ProfessionalsPlacesOfIntervention
INSERT INTO ProfessionalsPlacesOfIntervention (ProfessionalId, PlaceOfInterventionId)
VALUES
  ('14e8f8c3-1537-40d5-bb5a-1d90d7d9c500', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 1, Place of Intervention 1
  ('14e8f8c3-1537-40d5-bb5a-1d90d7d9c500', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 1, Place of Intervention 2
  ('2747c3a4-1f79-4f1b-8525-c1a54b17224a', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 2, Place of Intervention 3
  ('ac6e46a3-c36a-4c54-bc17-689fe29f450b', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 4, Place of Intervention 4
  ('dd1f3985-38fc-4ba3-80c0-67b987b33257', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 5, Place of Intervention 1
  ('1a390e1a-6626-4e27-925b-9d349ab475e4', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 6, Place of Intervention 2
  ('f8a0e89d-3f8d-489e-8394-b59445c7e865', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 1 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 7, Place of Intervention 2
  ('f8a0e89d-3f8d-489e-8394-b59445c7e865', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 7, Place of Intervention 3
  ('f8a0e89d-3f8d-489e-8394-b59445c7e865', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 7, Place of Intervention 4
  ('c648be6a-36e9-419c-9f79-14fe7b864c6d', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Place of Intervention 1
  ('c648be6a-36e9-419c-9f79-14fe7b864c6d', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Place of Intervention 3
  ('f824ce77-5b1a-4c6a-9151-bb1da1a704ac', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 8, Place of Intervention 4
  ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 9, Place of Intervention 1
  ('e0af09ec-7ad6-4c27-b146-b0cc194a9cb3', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 9, Place of Intervention 3
  ('6f6262b1-4291-4aa9-8ba5-1e8a0e9e7163', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 0 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 10, Place of Intervention 1
  ('d8d33c54-1e87-4ab6-a6a8-6c9269474a4d', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 11, Place of Intervention 4
  ('4b6141f8-481c-4eb7-8f5c-aa6e7a6c67b4', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 2 ROWS FETCH NEXT 1 ROW ONLY)), -- Professional 12, Place of Intervention 3
  ('1d0ed49a-149b-4654-98a5-8f39cfd0abf4', (SELECT Id FROM PlacesOfIntervention ORDER BY PlacesOfIntervention.Id OFFSET 3 ROWS FETCH NEXT 1 ROW ONLY)); -- Professional 13, Place of Intervention 4
  
  









