create table Users
(
	UserID VARCHAR(10) PRIMARY KEY,
	FullName VARCHAR(50) NOT NULL,
	Email VARCHAR(50) UNIQUE,
	PhoneNumber VARCHAR(10) NOT NULL,
	Address VARCHAR(50) NULL,
	DayOfBirth DATETIME NULL,
	Gender BIT NULL,
	Role VARCHAR(30) DEFAULT 'User'
)

create table Admins
(
	AdminID VARCHAR(10) PRIMARY KEY,
	UserID VARCHAR(10) FOREIGN KEY(UserID) REFERENCES Users(UserID)
)

create table Accounts
(
	AccountID VARCHAR(10) PRIMARY KEY,
	UserID VARCHAR(10) FOREIGN KEY(UserID) REFERENCES Users(UserID),
	UserName VARCHAR(50) NOT NULL,
	PasswordHash VARCHAR(100) NOT NULL,
	CreateAtDay DATETIME NULL
)

create table Feedbacks
(
	FeedbackID VARCHAR(10) PRIMARY KEY,
	UserID VARCHAR(10) FOREIGN KEY(UserID) REFERENCES Users(UserID),
	Title VARCHAR(50) NULL,
	Content TEXT NULL,
	FeedbackState INT NULL, -- 0: Not Response, 1: Response
	CreateAtDay DATETIME NULL
)

create table Supports 
(
	SupportID VARCHAR(10) PRIMARY KEY,
	AdminID VARCHAR(10) FOREIGN KEY(AdminID) REFERENCES Admins(AdminID),
	FeedbackID VARCHAR(10) FOREIGN KEY(FeedbackID) REFERENCES Feedbacks(FeedbackID),
	Content VARCHAR(100) NULL,
	CreateAtDay DATETIME NULL
)

create table Commissions
(
	CommissionID VARCHAR(10) PRIMARY KEY,
	CommissionType INT NULL, -- 1: Ticket, 2: Venue
	Percentage DECIMAL(10,2) NULL,
	CreateAtDay DATETIME NULL
)

create table Venues
(
	VenueID VARCHAR(10) PRIMARY KEY,
	OwnPlaceID VARCHAR(10) FOREIGN KEY(OwnPlaceID) REFERENCES Users(UserID),
	CommissionID VARCHAR(10) FOREIGN KEY(CommissionID) REFERENCES Commissions(CommissionID),
	Name VARCHAR(50) NOT NULL,
	Description TEXT NULL,
	Capacity INT NULL,
	Address VARCHAR(50) NULL,
	VenueStatus INT NULL, -- 0: Booked, 1: Available
	Price DECIMAL(10,2) NULL,
)

create table Bookings
(
	BookingID VARCHAR(10) PRIMARY KEY,
	VenueID VARCHAR(10) FOREIGN KEY(VenueID) REFERENCES Venues(VenueID),
	OrganizerID VARCHAR(10) FOREIGN KEY(OrganizerID) REFERENCES Users(UserID),
	DateStart DATETIME NULL,
	DateEnd DATETIME NULL,
	BookingDate DATETIME NULL,
	BookingStatus INT NULL, -- -1: Pending, 0: Rejected, 1: Approved
	Deposit DECIMAL(10,2) NULL
)

create table Events
(
	EventID VARCHAR(10) PRIMARY KEY,
	OrganizerID VARCHAR(10) FOREIGN KEY(OrganizerID) REFERENCES Users(UserID),
	VenueID VARCHAR(10) FOREIGN KEY(VenueID) REFERENCES Venues(VenueID),
	Name VARCHAR(50) NOT NULL,
	Description TEXT NULL,
	StartTime DATETIME NULL,
	EndTime DATETIME NULL,
	IsPublic BIT DEFAULT 1, -- 0: private , 1: public
	EventStatus INT NULL, -- -1: Pending, 0: Rejected, 1: Approved
)

create table Tickets
(
	TicketID VARCHAR(10) PRIMARY KEY,
	EventID VARCHAR(10) FOREIGN KEY(EventID) REFERENCES Events(EventID),
	CommissionID VARCHAR(10) FOREIGN KEY(CommissionID) REFERENCES Commissions(CommissionID),
	TicketType INT NULL, -- 1: Standard, 2: VIP
	Price DECIMAL(10,2) NULL,
	TotalQuantity INT NULL,
	SoldQuantity INT NULL,
)

create table Payments
(
	PaymentID VARCHAR(10) PRIMARY KEY,
	Method INT NULL, -- 1: Banking by number, 2: Banking by QR code
	PaymentStatus INT NULL, -- -1: Pending, 0: Failed, 1: Complete
	Price DECIMAL(10,2) NULL
)

create table Transactions
(
	TransactionID VARCHAR(10) PRIMARY KEY,
	PaymentID VARCHAR(10) FOREIGN KEY(PaymentID) REFERENCES Payments(PaymentID),
	TicketID VARCHAR(10) FOREIGN KEY(TicketID) REFERENCES Tickets(TicketID),
	UserID VARCHAR(10) FOREIGN KEY(UserID) REFERENCES Users(UserID),
	Quantity INT NULL,
	TransactionDate DATETIME NULL,
)

create table TicketOfUser
(
	UserID VARCHAR(10),
	TicketID VARCHAR(10),
	TransactionID VARCHAR(10),
	Status INT NULL, -- -1: Expired, 0: used, 1: unused
	PRIMARY KEY(UserID, TicketID, TransactionID),
	FOREIGN KEY(TransactionID) REFERENCES Transactions(TransactionID),
	FOREIGN KEY(TicketID) REFERENCES Tickets(TicketID),
	FOREIGN KEY(UserID) REFERENCES Users(UserID)
)
