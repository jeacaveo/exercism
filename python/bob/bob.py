# -*- coding: utf-8 -*-
"""
Bob is a lackadaisical teenager. In conversation, his responses are limited.

Bob answers 'Sure.' if you ask him a question.

He answers 'Whoa, chill out!' if you yell at him.

He says 'Fine. Be that way!' if you address him without actually saying
anything.

He answers 'Whatever.' to anything else.

"""

from __future__ import unicode_literals


def hey(message):
    """ Conversation module for Bob's A.I system. """

    def _is_silent(message):
        """ Silence is an empty or space/whitespace filled string. """
        return message.strip() == ''

    def _is_question(message):
        """ A question always ends with a '?'. """
        return message.endswith('?')

    def _is_shout(message):
        """ A shout is always in ALL CAPS. """
        return message.isupper()

    if _is_silent(message):
        return 'Fine. Be that way!'
    if _is_shout(message):
        return 'Whoa, chill out!'
    if _is_question(message):
        return 'Sure.'
    return 'Whatever.'
