puts 'Hello, and welcome to 7th grade English.'
puts 'My name is Missy Nesbit TacoPie.  And yo name is...?'
name = gets.chomp

if name == name.capitalize
    puts 'Well dandy doo look at you ' + name + '! Please kindly take a seat.'
else
    puts name + '?  Oh Me Oh My! Don\'t you mean ' + name.capitalize + '?'

    reply = gets.chomp

    if reply.downcase == 'yes'
        puts 'Now that\'s what I thought.  Always capitalize yo name silly sally!'
    else reply.downcase == 'no'
    puts 'Don\'t you go sassin\' me none.  I\'ll tan yo lil\' hide!'
    end
end