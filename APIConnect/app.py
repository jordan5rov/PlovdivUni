import requests

# API keys (if required)
WEATHER_API_KEY = ''
NASA_API_KEY = ''


# Weather API integration (OpenWeather)
def get_weather(city):
    url = f'http://api.openweathermap.org/data/2.5/weather?q={city}&appid={WEATHER_API_KEY}'
    response = requests.get(url)
    data = response.json()

    # Extract relevant information from the response
    temperature = data['main']['temp']
    weather = data['weather'][0]['description']
    return temperature, weather


# NASA API integration
def get_apod():
    url = f'https://api.nasa.gov/planetary/apod?api_key={NASA_API_KEY}'
    response = requests.get(url)
    data = response.json()

    # Extract relevant information from the response
    title = data['title']
    explanation = data['explanation']
    return title, explanation


# Earth Status App
def earth_status_app(city):
    temperature, weather = get_weather(city)
    print(f"Current weather in {city}: {temperature} K, {weather}")

    title, explanation = get_apod()
    print(f"Astronomy Picture of the Day: {title}")
    print(explanation)


# Example usage
earth_status_app('New York')
