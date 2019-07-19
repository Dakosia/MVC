CREATE DATABASE BestHookah
GO

USE BestHookah
GO

CREATE TABLE MenuSections
(
	MenuSectionId INT IDENTITY(1, 1) NOT NULL,
	MenuSectionName VARCHAR(255) NOT NULL,
	CONSTRAINT PK_MenuSectionId PRIMARY KEY (MenuSectionId)
)
GO

INSERT INTO MenuSections VALUES
('HOOKAH BAR'),
('DRINKS MENU')
GO




CREATE TABLE MenuPoints
(
	MenuPointId INT IDENTITY(1, 1) NOT NULL,
	MenuPointName VARCHAR(255) NOT NULL,
	MenuPointPrice FLOAT NOT NULL,
	MenuPointDescription VARCHAR(255) NOT NULL,
	MenuPointImagePath VARCHAR(500) NOT NULL,
	MenuSectionName VARCHAR(255) NOT NULL,
	CONSTRAINT PK_MenuPointId PRIMARY KEY (MenuPointId)
)
GO

INSERT INTO MenuPoints VALUES
('HOOKAH', 32.99, 'Al Fakher, Nakhla, Fumari, Vantage by Starbuzz, Tangiers, Starbuzz, Lavoo, Dark Side.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-home-img-1.jpg', 'HOOKAH BAR'),
('FRUIT BOWL', 36.99, 'Try our fruit bowl hookah with Grapefruit, Orange, Apple, Pineapple, Melon.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-home-img-2.jpg', 'HOOKAH BAR'),
('ART HOOKAH', 49.99, 'These all glass hookah are created using only the highest quality of glass.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-home-img-3.jpg', 'HOOKAH BAR'),
('HIGH HOOKAH', 79.99, 'It has special filters that make the smoking experience completely different.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-home-img-4.jpg', 'HOOKAH BAR'),
('MINT-TASTIC', 32.99, 'Try our gum-mint hookah with chocolate, ice cream, chocolate shake, cream.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-1.jpg', 'HOOKAH BAR'),
('VANILLA HOOKAH', 36.99, 'Try our premium vanilla hookah with peach, pomegranate, strawberry, cream.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-2.jpg', 'HOOKAH BAR'),
('BLUEBERRY CAKE', 49.99, 'Premium blueberry hookah with vanilla cake, gum-mint, chocolate, cream.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-3.jpg', 'HOOKAH BAR'),
('TASTY FRUIT COCKTAIL', 79.99, 'It has a special fruit flavor that makes the experience completely different.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-4.jpg', 'HOOKAH BAR'),
('ART HOOKAH', 49.99, 'These all glass hookah are created using only the highest quality of glass.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-home-img-3.jpg', 'DRINKS MENU'),
('TASTY FRUIT COCKTAIL', 79.99, 'It has a special fruit flavor that makes the experience completely different.', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-4.jpg', 'DRINKS MENU'),
('COSMO', 35.95, '', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-5.jpg', 'DRINKS'),
('MOHITO', 30.50, '', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-6.jpg', 'DRINKS'),
('WINE', 21.60, '', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-7.jpg', 'DRINKS'),
('LIQUOR', 28.30, '', '../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-hookah-_bar-img-8.jpg', 'DRINKS')
GO




CREATE TABLE Branches
(
	BranchId INT IDENTITY(1, 1) NOT NULL,
	BranchName VARCHAR(255) NOT NULL,
	BranchDescription VARCHAR(1000) NOT NULL,
	BranchAddress VARCHAR(100) NOT NULL,
	BranchPhone VARCHAR(25) NOT NULL,
	BranchHoursOfOperations VARCHAR(50) NOT NULL,
	CONSTRAINT PK_BranchId PRIMARY KEY (BranchId)
)
GO

INSERT INTO Branches VALUES
('HOOKAH BAR & LOUNGE', 'Our top Hookah Bar & Lounge is the premier lounge in Hollywood where you can chill in a relaxed atmosphere!', '6353 Yucca Street, Los Angeles, 
CA 90028', '(123) 345-6789', '2 PM to 3 AM Daily')
GO




CREATE TABLE BlogArticles
(
	BlogArticleId INT IDENTITY(1, 1) NOT NULL,
	BlogArticleName VARCHAR(255) NOT NULL,
	BlogArticleShortDescription VARCHAR(1000) NOT NULL,
	BlogArticleCreationDate DATE NOT NULL,
	BlogArticleAuthor VARCHAR(100) NOT NULL,
	BlogArticleContent VARCHAR(MAX) NOT NULL,
	BlogArticleImagePath VARCHAR(500) NOT NULL,
	CONSTRAINT PK_BlogArticleId PRIMARY KEY (BlogArticleId)
)
GO

INSERT INTO BlogArticles VALUES
('THE MOST COMMON MISTAKES WHEN MANAGING PERSONAL FINANCES', 'The ability to manage money competently is especially valuable quality in the conditions of financial crisis, when the purchasing power of the population is shrinking, inflation is rising, and currency exchange rates are completely unpredictable. Below are the common mistakes related to money affairs along with financial planning advice to help manage your own finances properly.', '12.11.2018', 'Demo User', 'The ability to manage money competently is especially valuable quality in the conditions of financial crisis, when the purchasing power of the population is shrinking, inflation is rising, and currency exchange rates are completely unpredictable. Below are the common mistakes related to money affairs along with financial planning advice to help manage your own finances properly.



The budget is the most basic thing in financial planning. It is therefore especially important to be careful when compiling the budget. To start you have to draw up your own budget for the next month and only after it you may make a yearly budget.



As the basis takes your monthly income, subtract from it such regular expenses as the cost of housing, transportation, and then select 20-30% on savings or mortgage loan payment.

The rest can be spent on living: restaurants, entertainment, etc. If you are afraid of spending too much, limit yourself in weekly expenses by having a certain amount of ready cash.



"When people borrow, they think that they should return it as soon as possible," said Sofia Bera, a certified financial planner and founder of Gen Y Planning company. And at its repayment spend all that earn. But it''s not quite rationally ".



If you don''t have money on a rainy day, in case of an emergency (e.g. emergency of car repairs) you have to pay by credit card or get into new debts. Keep on account of at least $1000 in case of unexpected expenses. And gradually increase the "airbag" to an amount equal to your income for up to three-six months.



"Usually when people plan to invest, they only think about profit and they don''t think that loss''s possible", says Harold Evensky, the President of the financial management company Evensky & Katz. He said that sometimes people do not do basic mathematical calculations.

For example, forgetting that if in one year they lost 50%, and the following year they received 50% of the profits, they did not return to the starting point, and lost 25% savings. Therefore, think about the consequences. Get ready to any options. And of course, it would be wiser to invest in several different investment objects.', '/Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-blog-img-1.jpg'),
('METHODS OF THE RECRUITMENT', 'Search of staff is not an easy task. According to the departmental heads'' of personnel management words, in order to find a personnel who will correspond to the relevant customer needs and requirements, it is necessary to carry out a great job.', '12.11.2018', 'Demo User', 'Search of staff is not an easy task. According to the departmental heads'' of personnel management words, in order to find a personnel who will correspond to the relevant customer needs and requirements, it is necessary to carry out a great job.

For search and selection of necessary staff, a variety of means from the arsenal of psychological science is used : biographical questionnaires, standardized and non-standartized interviews, jobs, modelling work and situational exercises, tests on achievement, personality, intelligence and abilities, polygraphic examinations and much more.



It cannot be said that the use of psychological methods is absolutely devoid of any complications.Though many years of experience in the use of funds in a competitive environment influence on details such as drafting employment contracts, ensuring full motivational package.



There are some psychological techniques borrowed from abroad and their adaptation in the vast majority of cases has been reduced to minimum. As a result, practices that still somehow can be used in search and selection of personnel do not meet basic requirements of psychrometric.

The second major obstacle to the use of modern psychological diagnostics in practice of professional selection is the low level of psychological training of managers of contracting authorities and, alas the candidates who wish to obtain working space without making much effort. So professional psychologists are not enough to manage a professional psychological selection of personnel and solving other problems at the company related to the estimation of the personnel. Also well-established psychological assessment tools that meet all necessary requirements are required.', '/Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-blog-img-2.jpg'),
('OVERALLS WITH LOGO AS A METHOD OF ADVERTISING', 'Overalls bearing the company''s logo are related to economy and practicality. A preference of corporate style involves a significant increase of costs for development of design solutions, customized tailoring, selection of necessary materials and so on.', '12.11.2018', 'Demo User', 'Overalls bearing the company''s logo are related to economy and practicality. A preference of corporate style involves a significant increase of costs for development of design solutions, customized tailoring, selection of necessary materials and so on.



Overalls long ago ceased to perform exclusively utilitarian function. Often the image part plays a very important role.



The choice does not cause interest for many businessmen and that is why it is ignored. A better solution for such businessmen is serving logotype on clothing, like sweatshirt or order of the t-shirts, hoodies. Such an approach also ensures recognition of firm, understanding of potential customers.

In some sorts of btl-actions promotional costumes are applied - spectacular and colourful advertising anchors that effectively attract attention. There is also a sense in applying logo  on the company clothing since under these conditions, it will be remembered at an intuitive level will complement the pleasant emotions of the event.

Workwear with logo of outline type is rather popular. There are some methods of implementing this kind of logo that require the possibility of large images. Transfer print gives a possibility of designing small accessories-handbags, caps, bandanas, etc.



It is important to understand that overalls and the company''s logo are images, the face of the company, it is a tool to be remembered by the clients.', '/Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-blog-img-4.jpg'),
('THE MAIN OBJECTIVES OF THE MARKETER', 'The modern market is absolutely unpredictable. And yet it lives according to strict laws. The marketers need to be known to achieve maximum results in their business - that is the main task of the marketer.', '12.11.2018', 'Demo User', 'The modern market is absolutely unpredictable. And yet it lives according to strict laws. The marketers need to be known to achieve maximum results in their business - that is the main task of the marketer.



Cold calculation or intuition?

"Maximum results" is a wide concept. What do professional marketers deal with?

At first glance, their work looks pretty boring. Thay learn what changes occur in the global market, how much the advertising budget of a competiting company grew and how it will affect the business development.



On the other hand, each task that they solve requires creativity. How to create branded products, how to conduct an advertising company, how to improve the product, through whom to organize and establish an effective dealer system, where to pave the way for an quick promotion...



The work in a marketing sphere is a combination of the system and directly the nature of man. It combines technology and art. Developing strategies, and building a brand are technologies of the content process. And art is in working with people. It requires talent, imagination and soul. After all, the attraction of buyers is communication, game, show.

The marketing is considered to be one of the most promising fields. This confirms the opening of new universities and specialized departments and faculties, where teachers and administration will "make" the geniuses in the field market management.', '/Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-blog-img-6.jpg'),
('RECESSION IS A GOOD OPPORTUNITY TO DEAL A DEATHBLOW TO THE COMPETITORS', 'Media prices are falling, so advertising becomes more profitable. The combination of low prices on media and weak competition gives companies the opportunity to cheaply grab market share.', '12.11.2018', 'Demo User', 'Media prices are falling, so advertising becomes more profitable. The combination of low prices on media and weak competition gives companies the opportunity to cheaply grab market share.

Then came truly frightening times for marketing managers. How to respond? What is the optimal strategy? There are several rules of survival in the times of crisis.



Do not panic. Most marketers assume that during the crisis consumers have sharply cut their spendings. In fact, consumer spendings rarely really fall, they simply grow more slowly, not at the pace of inflation.



Cut the correct costs. To the right are the administrative costs and even reduction of volumes of manufacture. It is impossible to start saving on quality of a product or its promotion.



Reduce of advertising costs inevitably will reduce your income. This is the easiest and fastest way to cut costs, but the reckoning is inevitable. Studies have shown that firms that reduce advertising costs during a recession typically experience 20-30% decline in sales and earnings over the next two years.



Reduce of advertising costs inflicts long-term harm. By results of researches, advertising has a lasting effect on sales: it becomes obvious in up to five years after the campaign. Cutting advertising budgets is hurting business for the long term. PIMS analysis shows that companies that shorten the ads need much more time to exit the crisis than all the rest (when the economic situation begins to improve).', '/Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-blog-img-8.jpg')
GO




CREATE TABLE Gallery
(
	ImageId INT IDENTITY(1, 1) NOT NULL,
	ImagePath VARCHAR(500) NOT NULL,
	ImageName VARCHAR(255) NULL,
	ImageDescription VARCHAR(500) NULL,
	CONSTRAINT PK_ImageId PRIMARY KEY (ImageId)
)
GO

INSERT INTO Gallery VALUES
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-9bg.jpg', 'mt-1616-gallery-img-9bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-1bg.jpg', 'mt-1616-gallery-img-1bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-2bg.jpg', 'mt-1616-gallery-img-2bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-3bg.jpg', 'mt-1616-gallery-img-3bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-4bg.jpg', 'mt-1616-gallery-img-4bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-12bg.jpg', 'mt-1616-gallery-img-12bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-5bg.jpg', 'mt-1616-gallery-img-5bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-6bg.jpg', 'mt-1616-gallery-img-6bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-7bg.jpg', 'mt-1616-gallery-img-7bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-11bg.jpg', 'mt-1616-gallery-img-11bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-8bg.jpg', 'mt-1616-gallery-img-8bg.jpg', ''),
('../Content/mt-demo/74300/74314/mt-content/uploads/2018/11/mt-1616-gallery-img-10bg.jpg', 'mt-1616-gallery-img-10bg.jpg', '')
GO




CREATE TABLE Offers
(
	OfferId INT IDENTITY(1, 1) NOT NULL,
	OfferName VARCHAR(255) NOT NULL,
	OfferShortDescription VARCHAR(500) NOT NULL,
	OfferExpirationDate DATE NOT NULL,
	CONSTRAINT PK_OfferId PRIMARY KEY (OfferId)
)
GO

INSERT INTO Offers VALUES
('ASSORTED 12 INCH HOOKAH', 'Special smoking pipe and scientific design', '07.12.2019'),
('BAZAAR 12 INCH BLACK HOOKAH', 'Round base shape, refreshing hookah', '07.16.2019'),
('BASEMENT BAZAAR 10 INCH HOOKAH', 'Glass product, refreshing hookah', '08.14.2019'),
('BLACK GLASS HOOKAH', 'Special smoking pipe, refreshing hookah', '07.30.2019'),
('GLASS HOOKAH', 'Round base shape, scientific design', '07.01.2019'),
('TRANSPARENT HOOKAH', 'Round base shape, glass product.', '08.01.2019')
GO




CREATE TABLE Notifications
(
	UserId INT IDENTITY(1, 1) NOT NULL,
	UserName VARCHAR(255) NOT NULL,
	UserEmail VARCHAR(255) NOT NULL,
	UserPhone VARCHAR(25) NOT NULL,
	CONSTRAINT PK_UserId PRIMARY KEY (UserId)
)
GO

INSERT INTO Notifications VALUES
('User1', 'user1@gmail.com', '+77011234567'),
('User2', 'user2@gmail.com', '+77051234567'),
('User3', 'user3@gmail.com', '+77771234567')
GO




CREATE TABLE Reserves
(
	ReserveId INT IDENTITY(1, 1) NOT NULL,
	ClientName VARCHAR(255) NOT NULL,
	ClientEmail VARCHAR(255) NOT NULL,
	ClientPhone VARCHAR(25) NOT NULL,
	ClientMessage VARCHAR(255) NOT NULL,
	ReserveDate DATE NOT NULL DEFAULT GETDATE(),
	CONSTRAINT PK_ReserveId PRIMARY KEY (ReserveId)
)
GO

INSERT INTO Reserves VALUES
('Client1', 'client1@gmail.com', '+77017654321', 'ClientMessage1', '06.30.2019'),
('Client2', 'client2@gmail.com', '+77057654321', 'ClientMessage2', '07.12.2019'),
('Client3', 'client3@gmail.com', '+77777654321', 'ClientMessage3', '07.15.2019'),
('Client4', 'client4@gmail.com', '+77777777777', 'ClientMessage4', GETDATE())
GO




CREATE TABLE Reviews
(
	ReviewId INT IDENTITY(1, 1) NOT NULL,
	UserName VARCHAR(255) NOT NULL,
	UserAddress VARCHAR(255) NOT NULL,
	ReviewContent VARCHAR(255) NOT NULL,
	CONSTRAINT PK_ReviewId PRIMARY KEY (ReviewId)
)
GO

INSERT INTO Reviews VALUES
('Kelly Harrison', 'Beverly Hills, Los Angeles, CA', 'Came here on Saturday night and loved this place! Nice stuff and music cozy atmosphere the best hookah I ever tried in Los Angeles thanks for having us,gonna be back pretty soon'),
('Sara Dunn', 'Beverly Hills, Los Angeles, CA', 'This hookah lounge is by far the best place to go! It doesn''t compare to any other place in the area. Good vibe, the staff is amazing always attentive and friendly! The music is always on point!'),
('Kara Sunn', 'Beverly Hills, Los Angeles, CA', 'It doesn''t compare to any other place in the area. Good vibe, the staff is amazing always attentive and friendly! The music is always on point!'),
('Sally Brown', 'Beverly Hills, Los Angeles, CA', 'Nice stuff and music cozy atmosphere the best hookah I ever tried in Los Angeles thanks for having us,gonna be back pretty soon. Came here on Saturday night and loved this place!'),
('Hara Harrison', 'Beverly Hills, Los Angeles, CA', 'Good vibe, the staff is amazing always attentive and friendly! The music is always on point! This hookah lounge is by far the best place to go! It doesn''t compare to any other place in the area.')
GO



SELECT * FROM MenuSections
SELECT * FROM MenuPoints
SELECT * FROM Branches
SELECT * FROM BlogArticles
SELECT * FROM Gallery
SELECT * FROM Offers
SELECT * FROM Notifications
SELECT * FROM Reserves
SELECT * FROM Reviews
GO