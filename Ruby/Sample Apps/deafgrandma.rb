response = ''

while response != 'Bye' 
    puts 'Hello there!  What do you say?'
    response = gets.chomp
    
if response == response.capitalize
        puts 'No, Not Since 19' + (rand (50)).to_s + '!'
else 
    puts 'Huh?! Speak Up, Sonny!'

end

end

puts 'BuBye Sonny Boy'