# Every-Word-Is-A-Google-Image
## [Installation](#installation)
To be able to use this Script, you need to enable Google Custom Search API, generate API key credentials and set a project for Google Images and set up a Genius app:
-   Visit [https://console.developers.google.com](https://console.developers.google.com) and click create project. Name it whatever you want and Location doesn't matter

-   Visit [https://console.developers.google.com/apis/library/customsearch.googleapis.com](https://console.developers.google.com/apis/library/customsearch.googleapis.com) and click enable on the "Custom Search API" for your project.

-   Visit [https://console.developers.google.com/apis/credentials](https://console.developers.google.com/apis/credentials) and click the CREATE CREDENTIALS button then select API key. Copy the token and put it in the GoogleToken.txt file

-   Visit [https://cse.google.com/cse/all](https://cse.google.com/cse/all) and Click Add, in sites to search put images.google.com and name the search engine whatever you like then click create, click on Modify Your search engine then click enable "Image search" option and then enable "Search the entire web". Copy your CX number from the Public Url and paste it in the GoogleToken.txt file as well separated by a space
- Visit [https://genius.com/api-clients](https://genius.com/api-clients) and either sign in or make a new Genius account. Then Click on New API Client, name it what you would like and put www.example.com for the app website URL and leave the rest blank and click save. Click on generate access token and copy that token into the GeniusToken.txt file.

- Open CMD/Terminal and enter these commands:
```bash
> pip install Google-Images-Search
> pip install lyricsgenius
```

## [Usage](#Usage)
```bash
> python Every-Word-Is-A-Google-Image.py
```
Enter the Artist Name and then the Song it will download all the images numbered in a folder called Images in the same directory.
Google has a limit of 100 images per day. The program will automatically wait till the next day to continue downloading images.
